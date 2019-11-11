using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using API_SIGNINAPP.Models;

namespace API_SIGNINAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>
        {
            new Student(1111, "Jane", "Brown"),
            new Student(222, "Jane", "Brown"),
        };

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            students[0].Enrollments.add(new Subject(1000, "intro Prog", "c#"));
            // sign-in-app.database.windows.net
            // username : milan
            // password : Swinburne1

            SqlConnection connection = new SqlConnection();
            string Query = "select * from Student";
            SqlCommand command = new SqlCommand(Query, connection);

            connection.Open();
            SqlDataReader result = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while(result.Read())
            {
                students.Add(new Student(int.Parse(result[0].ToString()), result[1].ToString(), result[2].ToString()));
            }

            connection.Close();                                   

            return students;
        }

        
    }
}
