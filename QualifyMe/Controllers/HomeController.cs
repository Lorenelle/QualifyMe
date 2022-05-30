using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QualifyMe.ServiceLayer;
using QualifyMe.ViewModels;

namespace QualifyMe.Controllers
{
    public class HomeController : Controller
    {
        private IStudentUsersService us;

        public HomeController(IStudentUsersService us)
        {
            this.us = us;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}