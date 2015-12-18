using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers.Admin
{
     [Authorize]
    public class AdminMenuController : Controller
    {
        // GET: AdminMenu
        public ActionResult AdminSushiBuffet()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 1;//Buffet
            int CategoryId = 2;//Sushi
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }
        [HttpGet]
        public ActionResult CreateSushiBuffet()
        {
            BLLServiceGateway<IEnumerable<Food>> Foodgate = new BLLServiceGateway<IEnumerable<Food>>();
            var food = Foodgate.GetItems("api/Food/").Where(item => item.CategaryId == 2);
          //  ViewBag.TypeId = new SelectList(type, "Id", "Name");
            ViewBag.FoodId = new SelectList(food, "Id", "Name");
        
            return View("CreateSushiBuffet");
        }

        [HttpPost]
        public ActionResult CreateSushiBuffet(Menu m)
        {
            m.MenuTypeId = 1;

            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();

            gate.PostItems("api/Menu/", m);

            return RedirectToAction("AdminSushiBuffet");
        }
        public ActionResult DeleteSushiBuffet(int id)
        {
             BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();
            gate.DeleteItems("api/Menu/" + id + "");
            return RedirectToAction("AdminSushiBuffet");
        }

         //takeaway Sushi
        public ActionResult AdminSushiTake()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 2;//Take away
            int CategoryId = 2;//Sushi
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }
        [HttpGet]
        public ActionResult CreateSushiTake()
        {
            BLLServiceGateway<IEnumerable<Food>> Foodgate = new BLLServiceGateway<IEnumerable<Food>>();
            var food = Foodgate.GetItems("api/Food/").Where(item => item.CategaryId == 2);
            //  ViewBag.TypeId = new SelectList(type, "Id", "Name");
            ViewBag.FoodId = new SelectList(food, "Id", "Name");

            return View("CreateSushiTake");
        }

        [HttpPost]
        public ActionResult CreateSushiTake(Menu m)
        {
            m.MenuTypeId = 2;

            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();

            gate.PostItems("api/Menu/", m);

            return RedirectToAction("AdminSushiTake");
        }
        public ActionResult DeleteSushiTake(int id)
        {
            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();
            gate.DeleteItems("api/Menu/" + id + "");
            return RedirectToAction("AdminSushiTake");
        }
         //Chinese Take away
        public ActionResult AdminChineseTake()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 2;//Take away
            int CategoryId = 1;//Chinese
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }
        [HttpGet]
        public ActionResult CreateChineseTake()
        {
            BLLServiceGateway<IEnumerable<Food>> Foodgate = new BLLServiceGateway<IEnumerable<Food>>();
            var food = Foodgate.GetItems("api/Food/").Where(item => item.CategaryId == 1);
            //  ViewBag.TypeId = new SelectList(type, "Id", "Name");
            ViewBag.FoodId = new SelectList(food, "Id", "Name");

            return View("CreateChineseTake");
        }

        [HttpPost]
        public ActionResult CreateChineseTake(Menu m)
        {
            m.MenuTypeId = 2;

            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();

            gate.PostItems("api/Menu/", m);

            return RedirectToAction("AdminChineseTake");
        }
        public ActionResult DeleteChineseTake(int id)
        {
            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();
            gate.DeleteItems("api/Menu/" + id + "");
            return RedirectToAction("AdminChineseTake");
        }

        //Chinese Buffet
        public ActionResult AdminChineseBuffet()
        {
            BLLServiceGateway<IEnumerable<Menu>> gate = new BLLServiceGateway<IEnumerable<Menu>>();
            int Typeid = 1;//Buffet
            int CategoryId = 1;//Chinese
            var menus = gate.GetItems("api/Menu/").Where(item => item.MenuTypeId == Typeid).Where(item => item.food.CategaryId == CategoryId);
            return View(menus);
        }
        [HttpGet]
        public ActionResult CreateChineseBuffet()
        {
            BLLServiceGateway<IEnumerable<Food>> Foodgate = new BLLServiceGateway<IEnumerable<Food>>();
            var food = Foodgate.GetItems("api/Food/").Where(item => item.CategaryId == 1);
            //  ViewBag.TypeId = new SelectList(type, "Id", "Name");
            ViewBag.FoodId = new SelectList(food, "Id", "Name");

            return View("CreateChineseBuffet");
        }

        [HttpPost]
        public ActionResult CreateChineseBuffet(Menu m)
        {
            m.MenuTypeId = 1;

            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();

            gate.PostItems("api/Menu/", m);

            return RedirectToAction("AdminChineseBuffet");
        }
        public ActionResult DeleteChineseBuffet(int id)
        {
            BLLServiceGateway<Menu> gate = new BLLServiceGateway<Menu>();
            gate.DeleteItems("api/Menu/" + id + "");
            return RedirectToAction("AdminChineseBuffet");
        }
    }
}