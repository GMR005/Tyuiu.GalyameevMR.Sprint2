using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task7.V14.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckShadedArea()
        {
            DataService DataService = new DataService(); 
            double x = 0.5;
            double y = 0.6;
            bool checker = true;
            bool res = DataService.CheckDotInShadedArea(x, y);
            Assert.AreEqual(checker, res);
        }
    }
}
