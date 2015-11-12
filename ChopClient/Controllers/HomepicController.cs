using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChopClient.Models;
using ChopClient.ViewModels;

namespace ChopClient.Controllers
{
    public class HomepicController : Controller
    {
        // GET: Homepic
        public ActionResult Index()
        {
            HomepicClient hc = new HomepicClient();
            ViewBag.listHomepics = hc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(HomepicViewModel hvm)
        {
            HomepicClient hc = new HomepicClient();
            hc.Create(hvm.pic);
            return RedirectToAction("Index");
        }

     
        public ActionResult Delete(int id)
        {
            HomepicClient hc = new HomepicClient();
            hc.Delelte(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            HomepicClient hc = new HomepicClient();
            HomepicViewModel hvm = new HomepicViewModel();
            hvm.pic = hc.find(id);
            return View("Edit",hvm);
        }

        [HttpPost]
        public ActionResult Edit(HomepicViewModel hvm)
        {
            HomepicClient hc = new HomepicClient();
            hc.Edit(hvm.pic);
            return RedirectToAction("Index");
        }
    }
}