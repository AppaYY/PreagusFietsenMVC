using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }
        public virtual Customer Customer{ get; set; }
        public virtual ICollection<Bike> Bikes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Store PickUp { get; set; }
        public virtual Store DropOff { get; set; }
    }
}