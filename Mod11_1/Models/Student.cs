using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mod11_1.Models
{
    public class Student
    {
        //Primary key 
        public int StudentID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [StringLength(10)]
        public string Studies { get; set; }

        //Foreing key
        public int ProjectID { get; set; }
        public int CourseID { get; set; }
        
        public virtual Project Project { get; set; }
        public virtual Course Course { get; set; }

    }
}