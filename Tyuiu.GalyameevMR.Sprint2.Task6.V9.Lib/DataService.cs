using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int nextMonth;
            int nextDay;
            string res = "";
            switch (m)
            {
                case 1:
                case 3: 
                case 5:
                case 7:
                case 8:
                case 10:
                    nextMonth = m;
                    nextDay = n + 1;
                    if (n == 31)
                    {
                        nextMonth = m + 1;
                    }
                    res = $"Завтра будет {nextMonth}.{nextDay}";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    nextMonth = m;
                    nextDay = n + 1;
                    if (n == 30)
                    {
                        nextMonth = m + 1;
                    }
                    res = $"Завтра будет {nextMonth}.{nextDay}";
                    break;
                case 2:
                    nextMonth = m;
                    nextDay = n + 1;
                    if (n == 28)
                    {
                        nextMonth = m + 1;
                    }
                    res = $"Завтра будет {nextMonth}.{nextDay}";
                    break;
                default:
                    if (m == 12 && n == 31 || n > 31 || n < 1 || m > 12 || m < 1)
                    {
                        throw new ArgumentException ("Данная дата неккоректна");
                    }
                    break;
            }
            return res;
        }
    }
}
