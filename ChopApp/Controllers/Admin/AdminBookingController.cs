using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers.Admin
{
    public class AdminBookingController : Controller
    {
        // GET: AdminBooking
        public ActionResult Index()
        {
            BLLServiceGateway<IEnumerable<Booking>> gate = new BLLServiceGateway<IEnumerable<Booking>>();
            var booking = gate.GetItems("api/Booking/").Where(model => model.BookingTime.Date == DateTime.Today);

            return View(booking);
        }


        public ActionResult Delete(int id)
        {
            BLLServiceGateway<Booking> gate = new BLLServiceGateway<Booking>();

            gate.DeleteItems("api/Booking/" + id + "");
            return RedirectToAction("Index");
        }

    }
}