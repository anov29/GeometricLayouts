using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CherwellCoding2020.Controllers
{

    [Route("api/[controller]")]
    public class GeometricController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "geometric controller";
        }
    
        [HttpGet]
        public string GetTriangle(int x, int y)
        {
            return "A1"; 
        }


    }
}