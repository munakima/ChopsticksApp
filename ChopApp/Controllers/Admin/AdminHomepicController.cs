using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChopApp.Models;
using ChopApp.Infrastructure;
using Models;


namespace ChopClient.Controllers
{
    [Authorize]
    public class AdminHomepicController : Controller
    {
        // GET: Homepic
        public ActionResult Index()
        {
            BLLServiceGateway<IEnumerable<HomePic>> gate = new BLLServiceGateway<IEnumerable<HomePic>>();
            var hc = gate.GetItems("api/HomePic/");

            return View(hc);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Create(HomePic hc)
        {
            BLLServiceGateway<HomePic> gate = new BLLServiceGateway<HomePic>();
            gate.PostItems("api/HomePic/", hc);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            BLLServiceGateway<HomePic> gate = new BLLServiceGateway<HomePic>();
            gate.DeleteItems("api/HomePic/" + id + "");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BLLServiceGateway<HomePic> gate = new BLLServiceGateway<HomePic>();
          //  HomepicViewModel hvm = new HomepicViewModel();
            HomePic hc = gate.GetItems("api/HomePic/" + id + "");
            return View("Edit", hc);
        }

        [HttpPost]
        public ActionResult Edit(HomePic hc)
        {
            BLLServiceGateway<HomePic> gate = new BLLServiceGateway<HomePic>();
            gate.PutItems("api/HomePic/" + hc.Id, hc);
            return RedirectToAction("Index");
        }
    }
}