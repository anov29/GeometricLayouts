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

        [HttpGet]
        public LinkedList<Point> GetTriangle(char? row, int? column)
        {
            LinkedList<Point> coordinates = new LinkedList<Point>();

            if (!row.HasValue || !column.HasValue) return coordinates;

            int columnInt = column.Value;
            char rowChar = row.Value; 

            Point point1, point2, point3;

            // upper left
            point1 = new Point((columnInt / 2) * 10, (char.ToUpper(rowChar) - 64) * 10);

            // bottom right
            point3 = new Point(((columnInt + 1) / 2) * 10, ((char.ToUpper(rowChar) + 1) - 64) * 10);

            // Odd column number means bottom left triangle 
            if (column % 2 != 0)
            {
                // bottom left point
                point2 = new Point((columnInt / 2) * 10, ((char.ToUpper(rowChar) + 1) - 64) * 10);
            }
            else // else upper right triangle
            {
                // upper left point
                point2 = new Point(((columnInt + 1 ) / 2) * 10, (char.ToUpper(rowChar) - 64) * 10);

            }

            coordinates.AddLast(point1);
            coordinates.AddLast(point2);
            coordinates.AddLast(point3);

            return coordinates; 
        }

    }
}