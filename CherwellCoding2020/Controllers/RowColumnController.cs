using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using CherwellCoding2020.Services; 

namespace CherwellCoding2020.Controllers
{
    [Route("/[controller]")]
    [Route("api/[controller]")]
    public class RowColumnController : Controller
    {

        [HttpGet]
        public string GetRowColumn(int? V1x, int? V1y, int? V2x, int? V2y, int? V3x, int? V3y)
        {

            if (!V1x.HasValue || !V1y.HasValue || !V2x.HasValue || !V2y.HasValue || !V3x.HasValue || !V3y.HasValue) return ""; 

            return RowColumnService.CalculateRowColumn(V1x.Value, V1y.Value, V2x.Value, V2y.Value, V3x.Value, V3y.Value); 
        }


    }
}