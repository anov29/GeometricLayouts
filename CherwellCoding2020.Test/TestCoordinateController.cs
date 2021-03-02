using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CherwellCoding2020.Controllers;
using System.Drawing;
using CherwellCoding2020.Services;

namespace CherwellCoding2020.Test
{
    [TestClass]
    public class TestCoordinateController
    {
        [TestMethod]
        public void TestGetTriangle()
        {
            // odd column
            List<Point> result = CoordinateService.CreateTriangle('F', 1);

            Assert.AreEqual(new Point(0, 0), result[0]); // upper left point
            Assert.AreEqual(new Point(0, 10), result[1]); // bottom left point
            Assert.AreEqual(new Point(10, 0), result[2]); // bottom right point 

            // even column
            result = CoordinateService.CreateTriangle('F', 2);

            Assert.AreEqual(new Point(10, 10), result[0]); // upper left point
            Assert.AreEqual(new Point(0, 10), result[1]); // upper right point
            Assert.AreEqual(new Point(10, 0), result[2]); // bottom right point 

            // 4th row 
            result = CoordinateService.CreateTriangle('C', 3);

            Assert.AreEqual(new Point(10, 30), result[0]); // bottom left point
            Assert.AreEqual(new Point(10, 40), result[1]); // bottom right point
            Assert.AreEqual(new Point(20, 30), result[2]); // bottom right point 

            // 6th row 
            result = CoordinateService.CreateTriangle('A', 12);

            Assert.AreEqual(new Point(60, 60), result[0]); // upper left point
            Assert.AreEqual(new Point(50, 60), result[1]); // bottom right point
            Assert.AreEqual(new Point(60, 50), result[2]); // bottom right point 
        }

    }
}
