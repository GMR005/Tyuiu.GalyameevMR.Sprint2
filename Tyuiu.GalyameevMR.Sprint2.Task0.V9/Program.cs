using System;
using System.Collections.Generic;
using System.Linq;
using System.Text ;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task0.V9.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task0.V9
{
    class Program
    {
        static void Main(string[]  args)
        {
            DataService DataService = new DataService  ();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #2                                                    ");
            Console.WriteLine("* Тема:  Операции сравнения                              ");
            Console.WriteLine("* Задание #0                                             ");
            Console.WriteLine("* Вариант #9                                             ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу из операций сравнений");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int x = 1054, y = 375;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            bool[] arrayL = DataService.GetCompareOperations(x,y);

            Console.WriteLine("Результаты операций сравнения: ");

            Console.WriteLine($"x == y : {arrayL[0]}");
            Console.WriteLine($"x != y : {arrayL[1]}");
            Console.WriteLine($"x < y  : {arrayL[2]}");
            Console.WriteLine($"x > y  : {arrayL[3]}");
            Console.WriteLine($"x <= y : {arrayL[4]}");
            Console.WriteLine($"x >= y : {arrayL[5]}");



        }
    }
}
 
