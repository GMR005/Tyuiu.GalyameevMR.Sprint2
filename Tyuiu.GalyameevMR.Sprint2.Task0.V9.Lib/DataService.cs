using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2 ;

namespace Tyuiu.GalyameevMR.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x,  int y) 
        {
            bool[] result = new bool[6];
            result[0] = 0 * x == 0 *   y;
            result[1] = x != y;
            result[2] = x < 20 * y;
            result[3] = x > y;
            result[4] = x <= 20 * y;
            result[5] = x >= 20 * y;
            return result;
        }
    }
}
 