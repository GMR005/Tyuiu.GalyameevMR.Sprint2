using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task5.V10.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DataService = new DataService(); 
            int g = 2022;
            int m = 3;
            int n = 30;

             DataService.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(2022, g);
            Assert.AreEqual(3, m);
            Assert.AreEqual(29, n);


        }
    }
}
