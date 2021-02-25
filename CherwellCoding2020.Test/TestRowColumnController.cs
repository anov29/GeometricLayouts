using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CherwellCoding2020.Controllers;
using System.Drawing;

namespace CherwellCoding2020.Test
{
    [TestClass]
    public class TestRowColumnController
    {
        [TestMethod]
        public void TestGetRowColumn()
        {
            var controller = new RowColumnController();
            string result = controller.GetRowColumn(0, 0, 0, 10, 10, 0);

            Assert.AreEqual("F1", result);   

            result = controller.GetRowColumn(60, 60, 50, 60, 60, 50);
        
            Assert.AreEqual("A12", result);  


        }
    }
}
