﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParkDal parkDal;
        public HomeController(IParkDal parkDal)
        {
            this.parkDal = parkDal;
        }
        // GET: Home
        public ActionResult Index()
        {
            List<Park> parks = parkDal.GetParks();
            return View("Index", parks);
        }
    }
}