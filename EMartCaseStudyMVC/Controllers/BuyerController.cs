using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMartCaseStudyMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMartCaseStudyMVC.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _Context;
        public BuyerController(BuyerContext context)
        {
            this._Context = context;
        }
        // GET: Buyer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Buyer buy)
        {

            try
            {
                _Context.Add(buy);
                _Context.SaveChanges();
                ViewBag.message = buy.bUname + "Successfully registered";
              
            }
            catch (Exception e)
            {
                ViewBag.message = buy.bUname + "Registeration Failed";
                
            }
            return View();
        }
        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Buyer buy1)
        {
            var loguser = _Context.Buyers.Where(e => e.bUname == buy1.bUname && e.Password == buy1.Password);
            if(loguser==null)
            {
                ViewBag.message = "Not Valid";
                return View();
            }
            else
            {
                return RedirectToAction("ListOfCat");
            }

            //try
            //{
            //    _Context.Add(buy1);
            //    _Context.SaveChanges();
            //    //ViewBag.message = buy1.bUname + "Successfully registered";
            //    return RedirectToAction("Index");
            //}
            //catch (Exception e)
            //{
            //    ViewBag.message = buy1.bUname + "Login Failed";
            //    return View();
            //}
        }
        public ActionResult ListOfCat()
        {
            return View();
        }
        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
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

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
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

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
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