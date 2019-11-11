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
    public class SubjectController : ControllerBase
    {
        List<Student> students = new List<Student>
        {
            new Student(1111, "Jane", "Brown"),
            new Student(222, "Jane", "Brown"),
        };



   
    }
}
