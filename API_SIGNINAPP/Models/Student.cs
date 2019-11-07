using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SIGNINAPP.Models
{
    public class Student
    {
        public int Barcode;
        public string firstName;
        public string lastName;

        public Student(int barcode, string firstname, string lastname)
        {
            this.Barcode = barcode;
            this.firstName = firstname;
            this.firstName = lastname;
        }


    }
}
