using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class Student
    {
        [Key]
        public int IHateTylerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int TotalCreditHours { get; set; }
    }
}