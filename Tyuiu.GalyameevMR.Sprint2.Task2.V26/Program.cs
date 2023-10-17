using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task2.V26.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #2                                                     ");
            Console.WriteLine("* Тема:  Оператор if – полная и короткая форма записи           ");
            Console.WriteLine("* Задание #2                                          ");
            Console.WriteLine("* Вариант #26                                            ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу на, которая запрашивает целые значения с клавиатуры и " +
                "вычисляет находится ли точка с координатами X,Y в заштрихованной области.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"Введите координаты точки");
            int x; int y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            bool dotLocation = DataService.CheckDotInShadedArea(x, y);
            if (dotLocation == true)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) принадлежит области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) не принадлежит области");
            }

        }
    }
}
