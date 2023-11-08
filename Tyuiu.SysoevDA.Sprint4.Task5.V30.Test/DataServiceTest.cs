using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint4.Task5.V30.Lib;
namespace Tyuiu.SysoevDA.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { { -2, 1, 3, 4, -1 },
                             { -2, -1, 0, -2, 3 },
                             { 1, 2, -2, 0, -1 },
                             { 2, -1, 4, -2, 2 },
                             { -2, -1, -2, 0, 1 } };
            Assert.AreEqual(23, ds.Calculate(matrix));
        }
    }
}
