using KleineApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KleineApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.Log(LogLevel.Information, "Get actie van WeatherForecast");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public string Hallo()
        {
            return "Hallo";
        }

        [HttpPost("/a/b/c/d/e")] // de route wordt vervangen
        public string Abcde()
        {
            return Request.Path;
        }

        [HttpPost("a/b/c/d/e/f")] // er wordt iets toegevoegd aan de route
        public string Abcdef()
        {
            return Request.Path;
        }

        [HttpPut("met-klasse")]
        public Abcd MaakObjectMetKlasse([FromBody] string input)
        {
            return new Abcd
            {
                A = 1,
                B = "twee",
                C = new CKlasse
                {
                    D = "in C",
                    Input = input
                }
            };
        }

        /// <summary>
        /// Eigenlijk is het niet nodig om de klasse <see cref="Abcd"/> te maken, als alleen <see cref="MaakObjectMetKlasse(string)"/> gebruik maakt van de klasse
        /// In deze actie zie je dat je hetzelfde kan bereiken met anonieme klassen.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut("anoniem")]
        public object MaakObjectAnoniem([FromBody] string input)
        {
            return new
            {
                A = 1,
                B = "twee",
                C = new
                {
                    D = "in C",
                    Input = input
                }
            };
        }


    }
}
