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
        public string ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}