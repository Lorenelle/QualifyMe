using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QualifyMe.ViewModels;
using QualifyMe.ServiceLayer;

namespace QualifyMe.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        private IStudentUsersService us;

        public AccountController(IStudentUsersService us)
        {
            this.us = us;   
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}