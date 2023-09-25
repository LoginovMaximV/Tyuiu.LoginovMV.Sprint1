using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LoginovMV.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            var res = (1 / (Math.Sqrt(x - 5 * y)));
            var res1 = Math.Round(res, 3);

            if(Math.Sqrt(x - 5 * y) > 0)
            {
                return res1;
            }
            if(Math.Sqrt(x - 5 * y) == 0)
            {
                Console.WriteLine("Знаменатель не может быть равнен нулю, введите другие значения");
                return -1;
            }
            else
            {
                Console.WriteLine("Число под корнем не может быть отрицательным, введите другие значения");
                return -1;
            }
        }
    }
}
