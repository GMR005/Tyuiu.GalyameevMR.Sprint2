using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d) 
        {
            bool[] logicArray = new bool[6];
            logicArray[0] = (0 * a == 0 * b) | (0 * c == 0 * d);
            logicArray[1] = (a != a) & (c != c) & (b != b) & (d != d);
            logicArray[2] = (0 * a == 0 * b) || (0 * c == 0 * d);
            logicArray[3] = (a >= d) && (b > c);
            logicArray[4] = !!(a == a);
            logicArray[5] = (a < b) ^ (c <= d);
            return logicArray;
        }
    }
}
