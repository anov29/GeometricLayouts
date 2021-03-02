using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CherwellCoding2020.Services
{
    public class RowColumnService
    {

        public static string CalculateRowColumn(int V1x, int V1y, int V2x, int V2y, int V3x, int V3y)
        {
            // find row 
            // row calculated by Y coordinate using V3, since V3 coordinate shared between both even and odd column triangles 
            char row = MapLetter(V3y);

            int column = 0;

            // find column 
            // first need to identify if the triangle is a bottom left or upper right triangle 
            // this can be determined by comparing V1 and V2
            // if V2 y is greater than V1 y, than it is a bottom left triangle 
            if (V2y > V1y) // bottom left triangle column can be found by((V3x.Value * 2) / 10) - 1
            {
                column = ((V3x * 2) / 10) - 1;
            }
            else // else a upper right triangle 
            {    // in this case, column can be found by (V3x * 2) / 10
                column = (V3x * 2) / 10;
            }

            return row + column.ToString();

        }

        // algorithm to map letters to correct column name 
        // first maps the y coordinate from a scale of 0 - 5, with 5 = A, and 0 = F, and then adds 64 to map it to correct char 
        private static char MapLetter(int value)
        {
            int x = (((value / 10) - 6) * -1) + 64;
            return Convert.ToChar(x);
        }

    }
}
