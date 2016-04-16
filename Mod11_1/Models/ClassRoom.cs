using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mod11_1.Models
{
    public class ClassRoom
    {
       
        public int ClassRoomID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public int NumberPCs { get; set; }

        [Required]
        public int Capacity { get; set; }

        [StringLength(10)]
        public string Floor { get; set; }

        [StringLength(10)]
        public string Wing { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}