using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task0.V9.Lib ;

namespace Tyuiu.GalyameevMR.Sprint2.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
            DataService DataService = new DataService ();
            int x = 1054;
            int y = 375;
            bool[] arrayLogic = { true, true, true, true, true,  false};
            bool[] array = DataService.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(arrayLogic, array);
        }
    }
}
 