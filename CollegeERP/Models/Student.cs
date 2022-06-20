using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeERP.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Middlename { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string gender { get; set; }


    }
 
}