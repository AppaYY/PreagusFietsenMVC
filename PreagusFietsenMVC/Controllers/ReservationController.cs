using PreagusFietsenMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreagusFietsenMVC.Controllers
{
    public class ReservationController : Controller
    {
        private BikeStoreContext db = new BikeStoreContext();
        public ActionResult Index()
        {
            return View(db.Reservations.ToList());
        }
    }
}