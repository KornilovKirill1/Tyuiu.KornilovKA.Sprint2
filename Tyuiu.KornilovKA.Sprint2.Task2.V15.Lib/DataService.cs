using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KornilovKA.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if(((y == 12) && ((x == 12) || (x == 13))) || ((y >= 3) && (y <= 11) && ((x == 12) || (x == 13))))
            {
                res = true;
            }
            else if(((x == 13) && (y >= 6) && (y <= 8)) || (((x == 9) || (x == 10)) && (y >= 3) && (y <= 8)))
            {
                res = true;
            }
            else if(((x >= 6) && (x <= 8) && (y >= 5) && (y <= 8)) || ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)))
            {
                res = true;
            }
            else if(((x == 2) && ((y == 5) || (y == 6))) || ((x >= 5) && (x <= 6) && (y >= 9) && (y <= 10)))
            {
                res = true;
            }
            else if(((x == 6) && (y == 11)) || ((y == 12) && ((x >= 4) && (x <= 6))) || ((y == 13) && ((x == 2) || (x == 3))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
