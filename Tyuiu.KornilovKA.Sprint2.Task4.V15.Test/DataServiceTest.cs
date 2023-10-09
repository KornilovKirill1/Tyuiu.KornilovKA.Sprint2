using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 4;

            double wait = 95.367;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 441;

            double wait = 1.134;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
