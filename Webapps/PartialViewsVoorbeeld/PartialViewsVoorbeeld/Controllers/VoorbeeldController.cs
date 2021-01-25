﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsVoorbeeld.Controllers
{
    public class VoorbeeldController : Controller
    {
        public IActionResult Index([FromServices] Models.VoorbeeldModel model)
        {
            return View(model);
        }
    }
}
