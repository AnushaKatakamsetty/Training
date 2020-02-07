using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookiesDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookiesDemo.Controllers
{
    public class CookieSessionController : Controller
    {
        public readonly UserAccountContext _context;
        //private object uc;

        public CookieSessionController(UserAccountContext context)

        {
            this._context = context;
        }
        // GET: CookieSession
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.UserName + "has got successfully Registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = uc.UserName + " Registeration Failed";
                return View();
            }

        }

        // GET: CookieSession/Details/5
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount uc1)
        {
            var logUser = _context.UserAccount.Where(e => e.UserName == uc1.UserName && e.Password == uc1.Password);
            if (logUser == null)
            {
                ViewBag.message = "Not Valid";


                return View();
            }
            else
            {
                HttpContext.Session.SetString("UName", uc1.UserName);
                HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }
        }
        [HttpGet]
        // GET: CookieSession/Create
        public ActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                ViewBag.uname = HttpContext.Session.GetString("lastLogin").ToString();
            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // POST: CookieSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}