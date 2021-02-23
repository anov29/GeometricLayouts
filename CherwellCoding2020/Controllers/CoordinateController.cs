using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CherwellCoding2020.Controllers
{
    [Route("/[controller]")]
    [Route("api/[controller]")]
    public class CoordinateController : Controller
    {

        [HttpGet]
        public string GetTriangle(int? x, int? y)
        {
            if (!y.HasValue || !x.HasValue) return "X and Y cannot be null."; 
            return "A1"; 
        }


    }
}