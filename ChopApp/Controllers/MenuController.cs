using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {//IEnumerable<Models.Food>      ChopApp.ViewModels.FoodViewModel

            return View();

        }
    }
}