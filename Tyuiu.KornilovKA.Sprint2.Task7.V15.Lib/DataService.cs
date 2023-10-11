using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KornilovKA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((Math.Pow(x, 2) + Math.Pow(y, 2) >= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4)) && (y >= 0))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
