using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gclowPortal.Models;

namespace gclowPortal.Controllers
{
    public class PortalController : Controller
    {
        public ActionResult Index()
        {
            var portal = new Portal() { Name = "testing", ID = 2, FiberChecked = true  
        };
            var str2 = new string[] { "Peanuts Cross Contact", "Eggs Cross Contact", "Milk/Dairy Cross Contact",
                "Shellfish Cross Contact", "Wheat Cross Contact", "Soy Cross Contact", "Mollusks Cross Contact",
                "Tree Nuts Cross Contact","Fish Cross Contact","Gluten Cross Contact"};
            ViewBag.Allergens = str2;
            return View(portal);
        }

        public ActionResult CustomFilter()
        {
            return View();
        }

        public ActionResult EditCustomFilter()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            //Content("") returns a string value to the page
            return Content("id = " + id); 
        }

        public ActionResult userQuery(int? pagerequested, string userName)
        {
            if (!pagerequested.HasValue)
                pagerequested = 1;
            if (String.IsNullOrWhiteSpace(userName))
                userName = "default_User";
            return Content(String.Format("Page requested: {0} " + "\n" + "User Name:  {1}"));
        }

    }
}