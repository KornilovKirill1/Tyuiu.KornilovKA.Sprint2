using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task2.V15.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 3;

            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
