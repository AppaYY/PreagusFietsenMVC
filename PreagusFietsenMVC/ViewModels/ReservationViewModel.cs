using PreagusFietsenMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreagusFietsenMVC.ViewModels
{
    public class ReservationViewModel
    {
        private BikeStoreContext _db = new BikeStoreContext();

        public Reservation Reservation { get; set; }
        public Customer Customer{ get; set; }
        public Bike Bike { get; set; }
        public SelectList AllBikes { get; set; }
        public int TotalPrice { get; set; }
        public ReservationViewModel() => AllBikes = new SelectList(_db.Bikes, "ID", "Type");

        //public ReservationViewModel(int Id)
        //{
        //    Reservation = new Reservation();
        //    Reservation.BikeID = Id;
        //    Bike = _db.Bikes.Find(Id);
        //    Bike.InStore = _db.Stores.Find(Bike.InStoreID);
        //}

        //public ReservationViewModel()
        //{
        //    Reservation = new Reservation();
        //    Reservation.BikeID = ViewData["BikeID"];
        //    Bike = _db.Bikes.Find(1);
        //    Bike.InStore = _db.Stores.Find(Bike.InStoreID);
        //}

        public void Save()
        {
            _db.Customers.Add(Customer);
            _db.Reservations.Add(Reservation);
            _db.SaveChanges();
        }
        


        public void CalculatePrice()
        {
            var start = Reservation.StartDate;
            var end = Reservation.EndDate;

            if (end.Year == start.Year && end.Month == start.Month && end.Day == start.Day)
            {
                TotalPrice = 5;
            } 
            else
            {
                TotalPrice = 10;
            }


        }
    }
}