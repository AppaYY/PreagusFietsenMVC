using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public CustomerGender Gender { get; set; }
        public double Height { get; set; }
        public string Email { get; set; }

        public enum CustomerGender
        {
            Male, Female, Other
        }
    }
}