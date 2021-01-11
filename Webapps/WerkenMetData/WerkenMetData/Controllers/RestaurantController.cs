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
        private Restaurant resto2;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resto">deze parameter wordt geleverd door Dependency Injection</param>
        public RestaurantController(Restaurant resto, Restaurant resto2)
        {
            // het private field resto wordt geïnitialiseerd met de waarde geleverd door dependency injection
            this.resto = resto;
            this.resto2 = resto2;
        }

        public IActionResult Index()
        {
            // aan het private field resto wordt nog een kelner toegevoegd.
            resto.Kelners.Add(new Kelner { Voornaam = "Pol" });
            resto2.Kelners.Add(new Kelner{ Voornaam = "Anne-Marie" });

            return View(resto);
        }
    }
}
