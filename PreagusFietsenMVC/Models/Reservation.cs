using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }
        public Customer Customer{ get; set; }
        public Bike Bike { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Store PickUp { get; set; }
        public Store DropOff { get; set; }
    }
}