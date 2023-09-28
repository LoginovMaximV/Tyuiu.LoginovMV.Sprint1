using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LoginovMV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[value.Length - i - 1]) return "";
                if (value.Length == 1) return "";
            }
            return value;
        }
    }
}
