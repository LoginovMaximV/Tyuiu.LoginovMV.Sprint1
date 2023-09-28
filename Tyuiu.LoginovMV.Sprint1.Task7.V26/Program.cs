using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #26                                                                                                 *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,               *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                         *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("*    (sin x^2) + y          x*y - 12                                                                         *");
            Console.WriteLine("* z = -------------   -    ---------                                                                         *");
            Console.WriteLine("*         y + 1             34 + x^2                                                                         *");

            double x, y;
            Console.WriteLine("Введите значение переменной х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной у:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }

    }
}
