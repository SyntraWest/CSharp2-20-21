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
        public IActionResult Index()
        {

            var resto = new Restaurant
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

            return View(resto);
        }
    }
}
