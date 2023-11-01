using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint4.Task3.V1.Lib;
namespace Tyuiu.SysoevDA.Sprint4.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = { { 3, 4, 3, 4, 1 },
                             { 8, 1, 6, 6, 9 },
                             { 9, 8, 5, 1, 3 },
                             { 1, 8, 7, 1, 2 },
                             { 9, 9, 7, 5, 6 } };
            Assert.AreEqual(36, ds.Calculate(array));
        }
    }
}
