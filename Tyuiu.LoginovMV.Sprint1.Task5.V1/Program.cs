using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                                                 *");
            Console.WriteLine("* Задание #5                                                                                                 *");
            Console.WriteLine("* Вариант #1                                                                                                 *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                                                       *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).                                      *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                                                          *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double x1;
            Console.WriteLine("Введите координату первой точки на оси Ох:");
            x1 = Convert.ToDouble(Console.ReadLine());

            double y1;
            Console.WriteLine("Введите координату первой точки на оси Оу:");
            y1 = Convert.ToDouble(Console.ReadLine());

            double x2;
            Console.WriteLine("Введите координату второй точки на оси Ох:");
            x2 = Convert.ToDouble(Console.ReadLine());

            double y2;
            Console.WriteLine("Введите координату второй точки на оси Оу:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadKey();

        }
    }
}
