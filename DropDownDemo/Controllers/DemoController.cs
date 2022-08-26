using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownDemo.Models;

namespace DropDownDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            var list = new List<string>() { "India", "America", "China", "Japan" };
            ViewBag.List = list;

            var countries = new List<country>() {
                new country() { id = 1, test="India"},
                new country() { id = 2, test="America"},
                new country() { id = 3, test="China"},
                new country() { id = 4, test="Japan"}
            };

            ViewBag.List = countries;
            //Emp emp = new Emp()
            //{
            //    country = "China"
            //};
            //return View(emp);

            Emp emp1 = new Emp() 
            { 
                country = 1
            };

            return View(emp1);
        }

        [HttpPost]
        public ActionResult Test(Emp emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }
            //var list = new List<string>() { "India", "America", "China", "Japan" };
            //ViewBag.List = list;

            var countries = new List<country>() {
                new country() { id = 1, test="India"},
                new country() { id = 2, test="America"},
                new country() { id = 3, test="China"},
                new country() { id = 4, test="Japan"}
            };

            ViewBag.List = countries;
            return View();
        }

        class country
        {
            public int id { get; set; }
            public string test { get; set; }
        }
    }
}