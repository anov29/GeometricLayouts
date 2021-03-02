using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CherwellCoding2020.Services
{
    public class CoordinateService
    {

        private static int rowHeight = 6;

        public static List<Point> CreateTriangle(char row, int column)
        {
            List<Point> coordinates = new List<Point>();

            Point point1, point2, point3;
            int rowIndex = char.ToUpper(row) - 65; // char A begins at 65

            if (0 > rowIndex || rowIndex >= (rowHeight + 1)) { return coordinates; } // check before mapping  

            // Odd column number means bottom left triangle 
            if (column % 2 != 0)
            {
                // bottom left 
                point1 = new Point((column / 2) * 10, MapRow(rowIndex + 1) * 10);
                // upper left
                point2 = new Point((column / 2) * 10, MapRow(rowIndex) * 10);
                // bottom right
                point3 = new Point(((column + 1) / 2) * 10, MapRow(rowIndex + 1) * 10);
            }
            else // else upper right triangle
            {
                // upper right
                point1 = new Point((column / 2) * 10, MapRow(rowIndex) * 10);
                // upper left
                point2 = new Point(((column - 1) / 2) * 10, MapRow(rowIndex) * 10);
                // bottom right
                point3 = new Point((column / 2) * 10, MapRow(rowIndex + 1) * 10);
            }

            coordinates.Add(point1);
            coordinates.Add(point2);
            coordinates.Add(point3);

            return coordinates;
        }

        // maps the char to the appropriate row
        // Algorithm is to subract row height from the char and multiply by -1
        // This creates the mapping 
        // A = 6, B = 5, C = 4, D = 3, E = 2, F = 1
        private static int MapRow(int charLocation)
        {
            return (charLocation - rowHeight) * -1;
        }


    }

}
