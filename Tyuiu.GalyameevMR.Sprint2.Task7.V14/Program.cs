using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task7.V14.Lib;


namespace Tyuiu.GalyameevMR.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService(); 
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #2                                                     ");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту      ");
            Console.WriteLine("* Задание #7                                             ");
            Console.WriteLine("* Вариант #14                                             ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные (вещественные значения)" +
                   "и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Введите координату X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y):");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            bool res;
            res = DataService.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
        }
    }
}
