using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class CheckingAccountController : Controller
    {
        // GET: CheckingAccount
        public ActionResult Index()
        {
            return Redirect("Home/Index");
        }

        //GET: CheckingAccount/Details/5
        public ActionResult Details()
        {
            var checkingAccount = new CheckingAccount { AccountNumber = "0000123456", FirstName = "Michael", LastName = "Sullivan", Balance = 500 };
            return View(checkingAccount);
        }

        //GET: CheckingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: CheckingAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }




    }
}