using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class Store
    {
        [Key]
        public int ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}