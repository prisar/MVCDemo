using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            };

            return View();
        }
    }
}