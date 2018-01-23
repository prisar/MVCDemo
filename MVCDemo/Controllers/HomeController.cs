using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from  MVC Application";
        }

        public string GetDetails()
        {
            return "Get Details invoked";
        }
    }
}