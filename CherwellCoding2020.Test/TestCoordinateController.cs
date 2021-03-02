using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CherwellCoding2020.Controllers;
using System.Drawing;

namespace CherwellCoding2020.Test
{
    [TestClass]
    public class TestCoordinateController
    {
        [TestMethod]
        public void TestGetTriangle()
        {
            var controller = new CoordinateController();

            // odd column
            List<Point> result = controller.GetTriangle('F', 1);

            Assert.AreEqual(new Point(0, 0), result[0]); // upper left point
            Assert.AreEqual(new Point(0, 10), result[1]); // bottom left point
            Assert.AreEqual(new Point(10, 0), result[2]); // bottom right point 

            // even column
            result = controller.GetTriangle('F', 2);

            Assert.AreEqual(new Point(10, 10), result[0]); // upper left point
            Assert.AreEqual(new Point(0, 10), result[1]); // upper right point
            Assert.AreEqual(new Point(10, 0), result[2]); // bottom right point 

            // 4th row 
            result = controller.GetTriangle('C', 3);

            Assert.AreEqual(new Point(10, 30), result[0]); // bottom left point
            Assert.AreEqual(new Point(10, 40), result[1]); // bottom right point
            Assert.AreEqual(new Point(20, 30), result[2]); // bottom right point 

            // 6th row 
            result = controller.GetTriangle('A', 12);

            Assert.AreEqual(new Point(60, 60), result[0]); // upper left point
            Assert.AreEqual(new Point(50, 60), result[1]); // bottom right point
            Assert.AreEqual(new Point(60, 50), result[2]); // bottom right point 
        }

    }
}
