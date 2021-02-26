using System;
using System.Drawing; 
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

        private int[] rowMapper = new int[] {6, 5, 4, 3, 2, 1, 0 }; // maps letters to the correct row 

        [HttpGet]
        public List<Point> GetTriangle(char? row, int? column)
        {
            List<Point> coordinates = new List<Point>();

            if (!row.HasValue || !column.HasValue) return coordinates;

            int columnInt = column.Value;
            char rowChar = row.Value; 

            Point point1, point2, point3;
            int rowIndex = char.ToUpper(rowChar) - 65; // char A begins at 65

            if (0 > rowIndex || rowIndex >= rowMapper.Length) { return coordinates; } // check before indexing 

            // Odd column number means bottom left triangle 
            if (column % 2 != 0)
            {
                // bottom left 
                point1 = new Point((columnInt / 2) * 10, rowMapper[(rowIndex + 1)] * 10);
                // upper left
                point2 = new Point((columnInt / 2) * 10, rowMapper[rowIndex] * 10);
                // bottom right
                point3 = new Point(((columnInt + 1) / 2) * 10, rowMapper[(rowIndex + 1)] * 10);
            }
            else // else upper right triangle
            {
                // upper right
                point1 = new Point((columnInt / 2) * 10, rowMapper[rowIndex] * 10);
                // upper left
                point2 = new Point(((columnInt - 1) / 2) * 10, rowMapper[rowIndex] * 10);
                // bottom right
                point3 = new Point((columnInt / 2) * 10, rowMapper[(rowIndex + 1)] * 10);
            }

            coordinates.Add(point1);
            coordinates.Add(point2);
            coordinates.Add(point3);

            return coordinates; 
        }

    }
}