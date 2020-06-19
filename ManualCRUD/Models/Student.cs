using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManualCRUD.Models
{
 
    [Table("Student")]
   
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Stream { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImagePath { get; set; }

    }
    
}