using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsVoorbeeld.Models
{
    public class VoorbeeldModel
    {

        public string Titel { get; set; }

        public List<VoorbeeldSubmodel> Submodellen { get; set; }


    }
}
