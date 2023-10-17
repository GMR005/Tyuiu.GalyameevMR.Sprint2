using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint2.Task6.V9.Lib;

namespace Tyuiu.GalyameevMR.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1"; 
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #2                                                    ");
            Console.WriteLine("* Тема:  Тернарный оператор                              ");
            Console.WriteLine("* Задание #6                                             ");
            Console.WriteLine("* Вариант #9                                           ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу, которая использует сокращенную форму записи " +
                "оператора switch вычисляет требуемое значение и возвращает результат.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int m, n;
            Console.WriteLine("Введите месяц");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string res;
            res = DataService.FindDateOfNextDay(m, n);
            Console.WriteLine(res);
        }
    }
}
