using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
           double res = 0;
           if (x > 1)
           {
                res = x + Math.Pow((x+3)/(x-1), x);
           }
           else if (x == 0)
           {
                res = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
           }
           else if (x > -26 && x < 2)
           {
                res = Math.Pow((3 + 2 / x * x), x);
           }
           else if (x < -26)
           {
                res = x + 10 * x - 1 / x;
           }
            res = Math.Round(res, 3);
            return res;
        }
    }
}
