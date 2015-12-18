using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        [HttpGet]
        public ActionResult Index()
        {
            var personNum=new List<int>();
            for (int i = 1; i < 40; i++)
            {
                personNum.Add(i);
            }
            ViewBag.PersonAdult = new SelectList(personNum);
            var babyNum = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                babyNum.Add(i);
            }
            ViewBag.PersonBaby = new SelectList(babyNum);
            return View("Index");
        }
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Index(Booking booking)
        {  
            BLLServiceGateway<Booking> gate = new BLLServiceGateway<Booking>();
            booking.Nowday = DateTime.Now;
            gate.PostItems("api/Booking/", booking);
            return RedirectToAction("Index");
        }

       

    }
}