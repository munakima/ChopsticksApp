using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChopApp.Infrastructure;
using Models;

namespace ChopApp.Controllers
{
    public class HomePicsController : Controller
    {
        // GET: HomePics
         public ActionResult Index()
        {
            BLLServiceGateway<IEnumerable<HomePic>> gate = new BLLServiceGateway<IEnumerable<HomePic>>();
            var homepics = gate.GetItems("api/HomePic/");
            return View(homepics);
        }     
    }
}