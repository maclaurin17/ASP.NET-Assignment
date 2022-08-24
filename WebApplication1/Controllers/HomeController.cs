using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.DB_Models;
using WebApplication1.Models.View_Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customers newcustomer)
        {
            try
            {
                var db = new Model1();
                var cust = new customer();
                cust.FirstName = newcustomer.FirstName;
                cust.LastName = newcustomer.LastName;
                cust.DateOfBirth = newcustomer.DOB;
                cust.RegistrationDate = DateTime.UtcNow.AddHours(1);
                db.customers.Add(cust);
                db.SaveChanges();
                return RedirectToAction("SuccessfulReg");
            }
            catch (Exception Ex)
            {

                ViewBag.ErrorMessage = "This is not the page you are looking for";
                return View();
            }
        }
        public ActionResult SuccessfulReg()
        {
            return View();
        }
    }


}