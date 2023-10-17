using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint2.Task1.V30.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckArrayLogic()
        {
            DataService DataService = new DataService(); 
            int a = 657, b = 874, c = 14, d = 654;
            bool[] logicArrayTest = { true, false, true, true, true, false };
            bool[] logicArray = DataService.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(logicArrayTest, logicArray);
        }
    }
}
