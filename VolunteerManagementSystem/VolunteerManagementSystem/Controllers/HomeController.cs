﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerManagementSystem.Models;

namespace VolunteerManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private List<Opportunity> opp;
        public HomeController() {
            opp = new List<Opportunity>
            {
                new Opportunity()
                { Center = "center1", Date = "1/30/19" },
                new Opportunity()
                { Center = "center2", Date = "2/12/19" }
            };
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Login model)
        {
           
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult ManageVolunteers()
        {
            return View();
        }
        public IActionResult ManageOpportunities()
        {
            return View(opp);
        }
        public IActionResult AddOpportunity()
        {
            return View();
        }
    
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
