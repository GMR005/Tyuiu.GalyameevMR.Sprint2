using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task4.V22.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService DataService = new DataService();
            double x = 1.0;
            double y = 2.0;
            double z = DataService.Calculate(x, y);
            Assert.AreEqual(23, z);
        }
    }
}
