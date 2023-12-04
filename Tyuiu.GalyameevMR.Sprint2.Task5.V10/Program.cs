using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task5.V10.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************"); 
            Console.WriteLine("* Спринт #2                                                    ");
            Console.WriteLine("* Тема:  Оператор switch                                 ");
            Console.WriteLine("* Задание #5                                             ");
            Console.WriteLine("* Вариант #10                                            ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу, которая использует оператор switch вычисляет " +
                "требуемое значение и возвращает результат.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Введите год (g):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер месяца (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string p = DataService.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine(p);
            Console.ReadKey();
           
        }
    }
}
