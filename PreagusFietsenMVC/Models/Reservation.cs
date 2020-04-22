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
        public int CustomerID { get; set; }
        public virtual Customer Customer{ get; set; }
        public int BikeID { get; set; }
        public virtual Bike Bike { get; set; }
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }
        public Store PickUp { get; set; }
        public Store DropOff { get; set; }
        [Display(Name = "Total price")]
        public double TotalPrice { get; set; }
    }
}