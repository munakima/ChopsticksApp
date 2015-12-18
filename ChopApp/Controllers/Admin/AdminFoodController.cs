using ChopApp.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChopApp.Controllers.Admin
{
   // [Authorize(Roles = "admin")]
    [Authorize]
    public class AdminFoodController : Controller
    {
        // GET: AdminFood
        public ActionResult Index()
        {
            BLLServiceGateway<IEnumerable<Food>> gate = new BLLServiceGateway<IEnumerable<Food>>();
            var food = gate.GetItems("api/Food/");

            return View(food);
        }


        [HttpGet]
        public ActionResult Create()
        {
            BLLServiceGateway<IEnumerable<Category>> gate = new BLLServiceGateway<IEnumerable<Category>>();
            var cats = gate.GetItems("api/Category/");
            ViewBag.CategaryId = new SelectList(cats, "Id", "Name");
          return View();
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Create(Food food)
        {
            BLLServiceGateway<IEnumerable<Category>> Categate = new BLLServiceGateway<IEnumerable<Category>>();
            var cats = Categate.GetItems("api/Category/");
            BLLServiceGateway<Food> gate = new BLLServiceGateway<Food>();
            ViewBag.CategaryId = new SelectList(cats, "id", "Name", food.CategaryId);
        
                gate.PostItems("api/Food/", food);
                return RedirectToAction("Index");

             
          // return View(food);
        }

       
        public ActionResult Delete(int id)
        {
            BLLServiceGateway<Food> gate = new BLLServiceGateway<Food>();

            gate.DeleteItems("api/Food/" + id + "");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BLLServiceGateway<Food> gate = new BLLServiceGateway<Food>();
            Food food = gate.GetItems("api/Food/" + id + "");
            BLLServiceGateway<IEnumerable<Category>> Categate = new BLLServiceGateway<IEnumerable<Category>>();
            var cats = Categate.GetItems("api/Category/");
            ViewBag.CategaryId = new SelectList(cats, "Id", "Name");
            return View("Edit", food);
        }

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            BLLServiceGateway<IEnumerable<Category>> Categate = new BLLServiceGateway<IEnumerable<Category>>();
            var cats = Categate.GetItems("api/Category/");
            BLLServiceGateway<Food> gate = new BLLServiceGateway<Food>();
            gate.PutItems("api/Food/" + food.Id, food);
            ViewBag.CategaryId = new SelectList(cats, "Id", "Name");
            return RedirectToAction("Index");
        }
    }
}