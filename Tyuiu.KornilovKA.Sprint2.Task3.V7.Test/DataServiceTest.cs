using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task3.V7.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 50;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.125;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -12;
            double wait = 20736.25;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
