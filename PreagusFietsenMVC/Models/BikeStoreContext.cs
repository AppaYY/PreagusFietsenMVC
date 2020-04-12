using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class BikeStoreContext : DbContext
    {
        public BikeStoreContext() : base("name=BikeStoreContext")
        {
        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}