﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalyameevMR.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 2 && x <= 5 && y >= 2 && y <= 7) || (x >= 5 && x <= 8 && y >= 4 && y <= 11) || (x >= 8 && x <= 10 && y >= 2 && y <= 4) || (x >= 9 && x <= 10 && y >= 4 && y <= 8) || (x >= 10 && x <= 13 && y >= 5 && y <= 8) || (x >= 9 && x <= 12 && y >= 10 && y <= 12) || (x >= 6 && x <= 9 && y >= 11 && y <= 12) || (x >= 8 && x <= 10 && y >= 12 && y <= 13))
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
