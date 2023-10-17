using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V20
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = ((x - 3) > y * 2 - 21) ? x * x + 12 * y - (2 / x) : (x * x + Math.Cos(x * x) + 17) / (y * y - Math.Sin(x * x) + 3);
            z = Math.Round(z, 3);
            return z;
        }
    }
}
