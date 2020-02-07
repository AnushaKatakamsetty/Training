using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCModelValidations.Models;
using HandsOnMVCModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCModelValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.country = new SelectList(new string[] { "India", "America", "Canada", "Africa" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository urepo = new UserRepository();
            urepo.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string nm,string psd)
        {
            UserRepository ure = new UserRepository();
            User user =ure.Validate(nm,psd);
            if (user != null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name ")]User item)
        {
            return View(item);
        }
    }
}