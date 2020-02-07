using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login item)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            return View(item);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Login item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
                return View(item);
        }

    }
}