using System.Collections.Generic;

namespace WerkenMetData.Models
{
    public interface IRestaurant
    {
        List<Kelner> Kelners { get; set; }
        string Naam { get; set; }
        List<Tafel> Tafels { get; set; }
    }
}