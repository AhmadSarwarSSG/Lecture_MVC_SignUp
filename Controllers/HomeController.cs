using Lecture_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Its will get only request from form that have method="get"
        //Similarly we can use [HttpPost] for post method
        [HttpGet] 
        public IActionResult signUp(string username, string email, string password)
        {
            User user01 = new User();
            user01.username = username;
            user01.email = email;
            user01.password = password;
            if(username!=null && password!=null && email!=null)
            {
                UserManagment Managment = new UserManagment();
                Managment.addUer(user01);
            }
            return View();
        }
    }
}
