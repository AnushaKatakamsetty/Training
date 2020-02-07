using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using AspCoreApplication;
namespace AspCoreApplication.Models
{
    public class EmployeeController : Controller
    {
        //EmployeeManagement emprepository;
        private readonly EmployeeManagement empre;
        public EmployeeController(EmployeeManagement empr)
        {
            empre = empr;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee emp1 = empre.GetEmployee(ID);
            //if (emp1 != null)
            //{
            //    return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
            //}
            //else
            //    return Content("employ does not exist");
            ViewData["id"] = emp1.id;
            ViewData["name"] = emp1.name;
            // ViewData["email"] = emp1.Email;
            ViewData["dept"] = emp1.Dept;

            return View();


        }
        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp6)
        {
            if (ModelState.IsValid)
            {
                empre.AddEmployee(emp6);
                return RedirectToAction("Index");
            }
            else
            return View("fail");
        }
        public IActionResult Index()
            {
            List<AspCoreApplication.Employee> elist2 = empre.DisplayDetails();
               return View(elist2);
            }
            public ViewResult AboutEmployee() 
            {
            Employee emp1 = empre.GetEmployee(2);
            //ViewBag.ProjectName = "EmployeePro";
            EmployeeProject ep = new EmployeeProject();
            ep.employeee = emp1;
            ep.ProjectName = "Project core";
                return View(ep);
            }
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist3 = (empre.DisplayDetails()).Where(e=>e.Dept==Dept.accounts).ToList();
            return View("~/Views/Employee/Index.cshtml",elist3);
        }
        //public IActionResult Create()
        //{
        //    Employee emp2 = empre.GetEmployee(2);
        //    return View(emp2);
        //}
        public IActionResult List()
        {
            List<Employee> elist = empre.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            bool re = empre.AddEmployee(employee);
            return RedirectToAction("Index");
        }
    }
    }

