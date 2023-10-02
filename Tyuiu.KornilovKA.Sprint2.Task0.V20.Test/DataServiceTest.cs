using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task0.V20.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 1075;
            int y = 275;
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
