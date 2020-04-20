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
        public SelectList AllBikes { get; set; }

        public ReservationViewModel() => AllBikes = new SelectList(_db.Bikes, "ID", "Type");

        public void Save()
        {
            _db.Reservations.Add(Reservation);
            _db.SaveChanges();
        }
    }
}