using ChopApp.Models;
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
          HomepicClient hc = new HomepicClient();
            ViewBag.listHomepics = hc.findAll();
            return View();
        }

    }
}