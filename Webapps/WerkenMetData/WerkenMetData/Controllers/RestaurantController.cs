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

        private static Restaurant resto = new Restaurant
        {
            Naam = "T'hof van Cleve",
            Kelners = new List<Kelner>
            {
                new Kelner { Voornaam = "Jos" },
                new Kelner { Voornaam = "Martine" }
            },
            Tafels = new List<Tafel>
            {
                new Tafel { Tafelnummer = 1 },
                new Tafel { Tafelnummer = 2 },
                new Tafel { Tafelnummer = 3 },
            },
        };

        public RestaurantController()
        {
        }

        public IActionResult Index()
        {
            resto.Kelners.Add(new Kelner { Voornaam = "Pol"});

            return View(resto);
        }
    }
}
