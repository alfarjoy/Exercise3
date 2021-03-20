using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required, Range(16, 99)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is required"), StringLength(200)]
        public string Address { get; set; }
    }
}