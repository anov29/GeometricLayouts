using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CherwellCoding2020.Controllers
{
    [Route("/[controller]")]
    [Route("api/[controller]")]
    public class RowColumnController : Controller
    {

        string[] letterMapper = new string[] { "F", "E", "D", "C", "B", "A"}; // maps letters to the correct row 

        [HttpGet]
        public string GetRowColumn(int? V1x, int? V1y, int? V2x, int? V2y, int? V3x, int? V3y)
        {
            if(!V1x.HasValue || !V1y.HasValue || !V2x.HasValue || !V2y.HasValue || !V3x.HasValue || !V3y.HasValue) return "";

            // find row 
            // row calculated by Y coordinate using V3, since V3 coordinate shared between both even and odd column triangles 
            string row = letterMapper[(V3y.Value / 10)];

            int column = 0;

            // find column 
            // first need to identify if the triangle is a bottom left or upper right triangle 
            // this can be determined by comparing V1 and V2
            // if V2 y is greater than V1 y, than it is a bottom left triangle 
            if (V2y > V1y) // bottom left triangle column can be found by((V3x.Value * 2) / 10) - 1
            {
                column = ((V3x.Value * 2) / 10) - 1;
            }
            else // else a upper right triangle 
            {    // in this case, column can be found by (V3x * 2) / 10
                column = (V3x.Value * 2) / 10;
            }

            return row + column.ToString(); 
        }

    }
}