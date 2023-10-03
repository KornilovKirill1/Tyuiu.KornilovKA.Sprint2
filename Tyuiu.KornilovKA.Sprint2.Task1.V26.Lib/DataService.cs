using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KornilovKA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //a = 654, b = 671, c = 874, d = 137
            bool[] res = new bool[6];

            res[0] = (a == b) | (c != d); //true
            res[1] = (a < b) & (c > d); //true
            res[2] = (a <= b) || (c >= d); //true
            res[3] = (a + 17 == b) && (c < d); //false
            res[4] = !(res[3]); //true
            res[5] = (a < b) ^ (c > d); //false

            return res;
        }
    }
}
