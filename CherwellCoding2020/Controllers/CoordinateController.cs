using System;
using System.Drawing; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http; 
using Microsoft.AspNetCore.Mvc;
using CherwellCoding2020.Services; 

namespace CherwellCoding2020.Controllers
{
    [Route("/[controller]")]
    [Route("api/[controller]")]
    public class CoordinateController : Controller
    {

        [HttpGet]
        public List<Point> GetTriangle(char? row, int? column)
        {

            if (!row.HasValue || !column.HasValue) return new List<Point>();
            
            return CoordinateService.CreateTriangle(row.Value, column.Value); 
        }
    }
}