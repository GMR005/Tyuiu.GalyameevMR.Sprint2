using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task6.V9.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckNextMonth()
        {
            DataService DataService = new DataService();
            int m = 10;
            int n = 10;
            string res = DataService.FindDateOfNextDay(m, n);
            Assert.AreEqual(res, $"Завтра будет {m}, {11}");
        }
    }
}
