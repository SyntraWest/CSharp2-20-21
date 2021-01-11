using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WerkenMetData.Models;

namespace WerkenMetData.Controllers
{
    public class RestaurantController : Controller
    {

        private Restaurant resto;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resto">deze parameter wordt geleverd door Dependency Injection</param>
        public RestaurantController(Restaurant resto)
        {
            // het private field resto wordt geïnitialiseerd met de waarde geleverd door dependency injection
            this.resto = resto;
        }

        public IActionResult Index()
        {
            // aan het private field resto wordt nog een kelner toegevoegd.
            resto.Kelners.Add(new Kelner { Voornaam = "Pol"});

            return View(resto);
        }
    }
}
