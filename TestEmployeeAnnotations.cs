using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AnnotationsDemo
{
    class TestEmployeeAnnotations
    {
        public static void Test()
        {
            Employee emp = new Employee();
            emp.FirstName = "Ruthik ";
            emp.LastName = "Reddy ";
            emp.Age = 88;
            emp.PhoneNumber = "1234567890";
            emp.Email = "Absc@gmail.com";

            ValidationContext context = new ValidationContext(emp);
            List<ValidationResult> resultlist = new List<ValidationResult>();
            bool valid =Validator.TryValidateObject(emp, context,resultlist,true);
            if(!valid)
            {
                foreach(ValidationResult res in resultlist)
                {
                   Console.WriteLine("Member Name :{0}",res.MemberNames.First() + "====" + Environment.NewLine);
                   Console.WriteLine("error message: {0}-{1}", res.ErrorMessage, Environment.NewLine);
                }
                
            }
            else
            {
                Console.WriteLine("fisrt" + emp.FirstName + emp.LastName + emp.PhoneNumber + emp.Email + emp.Age);
            }
        }
    }
}
