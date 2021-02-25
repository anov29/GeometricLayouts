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
            List<Point> result = controller.GetTriangle('A', 5);

            Assert.AreEqual(new Point(20, 0), result[0]); // upper left point
            Assert.AreEqual(new Point(20, 10), result[1]); // bottom left point
            Assert.AreEqual(new Point(30, 10), result[2]); // bottom right point 

            // even column
            result = controller.GetTriangle('A', 6);

            Assert.AreEqual(new Point(20, 0), result[0]); // upper left point
            Assert.AreEqual(new Point(30, 0), result[1]); // upper right point
            Assert.AreEqual(new Point(30, 10), result[2]); // bottom right point 

            // 2nd row 
            result = controller.GetTriangle('B', 1);

            Assert.AreEqual(new Point(0, 10), result[0]); // upper left point
            Assert.AreEqual(new Point(0, 20), result[1]); // bottom right point
            Assert.AreEqual(new Point(10, 20), result[2]); // bottom right point 

            // 3rd row 
            result = controller.GetTriangle('c', 6);

            Assert.AreEqual(new Point(20, 20), result[0]); // upper left point
            Assert.AreEqual(new Point(30, 20), result[1]); // upper right point
            Assert.AreEqual(new Point(30, 30), result[2]); // bottom right point 
        }

    }
}
