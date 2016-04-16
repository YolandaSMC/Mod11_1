using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mod11_1.Models
{
    public class Course
    {
        
        public int CourseID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Description { get; set;}
        
        //Foreign key
        public int ClassID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}