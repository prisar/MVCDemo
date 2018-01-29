using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinesLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinesLayer.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            foreach(string key in formCollection.AllKeys)
            {
                Response.Write("Key = " + key + "   ");
                Response.Write(formCollection[key]);
                Response.Write("<br />");
            }
            return View();
        }
    }
}