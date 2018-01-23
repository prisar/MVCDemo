using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "Id = " + id + " Name  = " + Request.QueryString["name"];
        }
        public string GetDetails()
        {
            return "Get Details invoked";
        }
    }
}