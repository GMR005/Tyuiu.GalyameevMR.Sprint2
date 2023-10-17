using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task3.V22.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DataService = new DataService();
            double x = 1.0; 
            double res = DataService.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}
