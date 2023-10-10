using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 1980;
            int m = 10;
            int n = 28;

            double wait = 1980.10;

            double res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual()
        }
    }
}
