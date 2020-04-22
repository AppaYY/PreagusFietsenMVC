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
        public ReservationViewModel() => AllBikes = new SelectList(_db.Bikes, "ID", "Type");

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
            var SelectedBike = _db.Bikes.Find(Reservation.BikeID);
            double hourPrice = SelectedBike.HourRate;
            double dayPrice = SelectedBike.DailyRate;
            if (end.Year == start.Year && end.Month == start.Month && end.Day == start.Day)
            {
                TimeSpan interval = end - start;
                double hours = interval.TotalHours;                
                Reservation.TotalPrice = hourPrice * hours;
            }
            else
            {
                TimeSpan interval = end - start;
                double days = interval.Days;
                Reservation.TotalPrice = dayPrice * days;
            }
        }
    }
}