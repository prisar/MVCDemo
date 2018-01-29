using System;
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
        public ActionResult Create(string name, string gender, string city, DateTime dateOfBirth)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Gender = gender;
            employee.City = city;
            employee.DateOfBirth = dateOfBirth;

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmployee(employee);

            return RedirectToAction("Index");
        }
    }
}