using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCwebapps.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwebapps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //methods in controllers that manage views are called actions
        //all actions in .NET return some form of an IAction result
        //Usually you just return a view, but you can return a redirect action
        public IActionResult Index()
        {
            //return view with no parameters, tries to find a view that matches the name of the action
            //this action will look for home/index in the view section
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
    }
}
