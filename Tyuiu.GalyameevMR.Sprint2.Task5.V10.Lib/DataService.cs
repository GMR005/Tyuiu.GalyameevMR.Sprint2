using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task5.V10.Lib
{
    public class DataService: ISprint2Task5V10
    {
        public int FindDateOfPreviousDay(int g, int m, int n)
        { 
            

            switch (m)
            {
                case 1:
                    n = n - 1;
                    m = m;
                    g = g;
                    if (n == 1)
                    {
                        m = 12;
                        g = g - 1;

                    }
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    n = n - 1;
                    m = m;
                    g = g;
                    if (n == 1)
                    {
                        m = m - 1;
                    }
                    break;
                case 3:

                case 5:
                case 7:
                case 10:
                case 12:
                    g = g;
                    m = m;
                    n = n - 1;
                    if (n == 1)
                    {
                        m = m - 1;
                    }
                    break;
                default:
                    return 0;     
            }
            return g;
            return m;
            return n-1;

        }

        
    }
}
