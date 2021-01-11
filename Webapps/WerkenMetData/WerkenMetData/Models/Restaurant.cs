using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WerkenMetData.Models
{

    public class Restaurant
    {
        public Restaurant()
        {
            Tafels = new List<Tafel>();
            Kelners = new List<Kelner>();
        }

        /// <summary>
        /// Naam van het restaurant
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// De tafels van het restaurant
        /// </summary>
        public List<Tafel> Tafels { get; set; }

        /// <summary>
        /// De mensen die opdienen in het restaurant
        /// </summary>
        public List<Kelner> Kelners { get; set; }
    }
}
