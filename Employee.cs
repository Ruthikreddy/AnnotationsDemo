using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationsDemo
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter FirstName")]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter LastName")]
        //[StringLength()]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Range(18,99,ErrorMessage ="Age should be between 18 and 99")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
