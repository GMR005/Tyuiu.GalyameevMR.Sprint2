using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task2.V26.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckShadeArea()
        {
            DataService DataService = new DataService();
            int x = 7; 
            int y = 8;
            bool twoDots = true;
            bool checkDots = DataService.CheckDotInShadedArea(x, y);
            Assert.AreEqual(checkDots, twoDots);
        }
    }
}
