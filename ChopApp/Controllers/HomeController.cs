using ChopApp.Infrastructure;
using ChopApp.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLLServiceGateway<IEnumerable<HomePic>> gate = new BLLServiceGateway<IEnumerable<HomePic>>();
            var homepics = gate.GetItems("api/HomePic/");

            return View(homepics);
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}