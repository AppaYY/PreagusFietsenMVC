using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using PreagusFietsenMVC.Models;

namespace PreagusFietsenMVC.Controllers
{
    public class HomeController : Controller
    {
        private BikeStoreContext _db = new BikeStoreContext();

        public ActionResult Index()
        {
            var bikes = _db.Bikes.Include(b => b.InStore);
            return View(bikes.ToList());
        }

        public ActionResult GetBike(int Id)
        {
            return RedirectToAction("SaveID", "Reservations", "Create");
        }

        public ActionResult SaveID(int Id)
        {
            ViewBag.BikeID = Id;
            return View();
        }

    }
}