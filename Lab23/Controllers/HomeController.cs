using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeEntities ORM = new CoffeeEntities();

            ViewBag.Items = ORM.Items.ToList();
            ViewBag.Users = ORM.Users.ToList();

            return View();
        }

        public ActionResult Register()
        {
            CoffeeEntities ORM = new CoffeeEntities();

            return View();
        }

        public ActionResult RegSuccess(User data)
        {
            CoffeeEntities ORM = new CoffeeEntities();

            ViewBag.Users = ORM.Users.ToList();

            if (ModelState.IsValid)
            {
                ORM.Users.Add(data);
                ORM.SaveChanges();
                ViewBag.message = $"{data.FirstName} has been added";
            }
            else
            {
                ViewBag.message = "Item is not valid, cannot add to DB.";
            }

            return View();
        }

        public ActionResult Users()
        {
            CoffeeEntities ORM = new CoffeeEntities();

            ViewBag.Users = ORM.Users.ToList();

            return View();
        }
    }
}