using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebappMetHtmlFormsVorbeeld.Models;

namespace WebappMetHtmlFormsVorbeeld.Controllers
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
            // met GET
            string email = Request.Query["email"];

            // met POST
            if (email == null)
                try
                {
                    email = Request.Form["email"];
                }
                catch (Exception)
                {

                }

            return View();
        }

        public IActionResult NietThuis()
        {

            // met GET
            string kleur = Request.Query["kleur"];

            // met POST
            if (kleur == null)
            {
                try
                {
                    kleur = Request.Form["kleur"];
                }
                catch (Exception)
                {

                }
            }

            ViewBag.Kleur = kleur;
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
