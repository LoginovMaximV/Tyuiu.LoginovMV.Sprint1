using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint1.Task4.V17.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Class Math                                                                                           *");
            Console.WriteLine("* Задание #4                                                                                                 *");
            Console.WriteLine("* Вариант #17                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                    *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                                                   *");
            Console.WriteLine("* Формула: 1 / sqrt(x - 5*y)   Ответ округлите до 3 знаков после запятой.                                    *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double x;
            Console.WriteLine("Введите переменную x:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите переменную y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine(" 1 / Sqrt(x - 5 * y) =" + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
