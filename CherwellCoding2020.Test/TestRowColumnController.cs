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
    public class TestRowColumnController
    {
        [TestMethod]
        public void TestGetRowColumn()
        {
            string result = RowColumnService.CalculateRowColumn(0, 0, 0, 10, 10, 0);

            Assert.AreEqual("F1", result);   

            result = RowColumnService.CalculateRowColumn(60, 60, 50, 60, 60, 50);
        
            Assert.AreEqual("A12", result);

            result = RowColumnService.CalculateRowColumn(10, 20, 0, 20, 10, 10);

            Assert.AreEqual("E2", result);

        }
    }
}
