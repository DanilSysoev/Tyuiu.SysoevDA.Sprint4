using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint4.Task2.V15.Lib;

namespace Tyuiu.SysoevDA.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1 };
            Assert.AreEqual(14, ds.Calculate(array));
        }
    }
}
