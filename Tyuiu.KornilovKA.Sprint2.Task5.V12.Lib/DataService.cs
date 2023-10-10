using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KornilovKA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {

            switch (n)
            {
                case 1:
                    switch(m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 29;
                                    break;
                                default:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break; 
                    default:
                    if(n < 1 || n > 31)
                    {
                        return $"Количество дней от 1 до 31. Значение {n}";
                    } else
                    {
                        n--;
                        break;
                    }

            }

            return $"{n}.{m}.{g}";
        }
    }
}
