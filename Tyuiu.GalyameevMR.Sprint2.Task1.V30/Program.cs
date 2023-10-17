using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task1.V30.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task1.V30
{
    class Program
    {

        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #2                                                    ");
            Console.WriteLine("* Тема:  Логические операции                             ");
            Console.WriteLine("* Задание #1                                            ");
            Console.WriteLine("* Вариант #30                                             ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу из операций сравнений и логических операций");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int a = 657, b = 874, c = 14, d = 654;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d ={d}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            bool[] arrayL = DataService.GetLogicOperations(a, b, c, d);
            Console.WriteLine(arrayL[0]);
            Console.WriteLine(arrayL[1]);
            Console.WriteLine(arrayL[2]);
            Console.WriteLine(arrayL[3]);
            Console.WriteLine(arrayL[4]);
            Console.WriteLine(arrayL[5]);
        }
    }
}
