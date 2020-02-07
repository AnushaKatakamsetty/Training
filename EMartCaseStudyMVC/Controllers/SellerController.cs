using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EMartCaseStudyMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMartCaseStudyMVC.Controllers
{
    public class SellerController : Controller
    { 
        public readonly SellerContext _Context;
        private readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(SellerContext context, IWebHostEnvironment hostingEnvironment)
        {
            this._Context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
    // GET: Buyer
    public ActionResult Index()
    {
        return View(_Context.Seller.ToList());
    }
    [HttpGet]
    public ActionResult SellerRegister()
    {
        return View();
    }
    [HttpPost]
    public ActionResult SellerRegister(SellerViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newSeller = new Seller
                {
                    sid = model.sid,
                    sname = model.sname,
                    spassword = model.spassword,
                    scompanyname = model.scompanyname,
                    sgstin = model.sgstin,
                    saboucompany = model.saboucompany,
                    saddress = model.saddress,
                    swebsite = model.swebsite,
                    semailid = model.semailid,
                    smobileno = model.smobileno,


                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    PhotoPath = uniqueFileName
                };

                _Context.Add(newSeller);
                _Context.SaveChanges();
                return RedirectToAction("Details", new { id = newSeller.sid });
            }

            return View();
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}

            //try
            //{
            //    _Context.Add(sell);
            //    _Context.SaveChanges();
            //    ViewBag.message = sell.sname + "Successfully registered";

            //}
            //catch (Exception e)
            //{
            //    ViewBag.message = sell.sname + "Registeration Failed";

            //}
            //return View();
        }


        [HttpGet]
    public ActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Login(Seller sell1)
    {
        var loguser = _Context.Seller.Where(e => e.sname == sell1.sname && e.spassword == sell1.spassword);
        if (loguser == null)
        {
            ViewBag.message = "Not Valid";
            return View();
        }
        else
        {
            return RedirectToAction("Operations");
        }
    }
            // GET: Seller
      

        // GET: Seller/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                ViewBag.message = "Not Valid ID";
                return View();
            }
            var seller = _Context.Seller.FirstOrDefault(m => m.sid == id);
            if (seller== null)
            {
                ViewBag.message = "Not Valid Seller";
                return View();
            }

            return View(seller);
            
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create()
        //{

           
        //}

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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