using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers
{
    public class MenusController : Controller
    {
        // GET: Buffet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SushiBuffet()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 1;
            int CategoryId = 2;
            //"api/Menu?Typeid=" + Typeid + "&CategoryId=" + CategoryId + ""
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }

        public ActionResult ChineseBuffet()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 1;
            int CategoryId = 1;
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }

        public ActionResult ChineseTakeAway()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 2;
            int CategoryId = 1;
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }

        public ActionResult SushiTakeAway()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 2;
            int CategoryId = 2;
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }
    }
}