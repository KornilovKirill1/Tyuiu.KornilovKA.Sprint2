using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint2.Task1.V26.Lib;

namespace Tyuiu.KornilovKA.Sprint2.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;

            bool[] wait = new bool[6] { true, true, true, false, true, false };

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
