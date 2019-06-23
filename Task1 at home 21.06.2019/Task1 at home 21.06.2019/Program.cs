using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_at_home_21._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =new int[] { 4, 6, 9, 7 };

            CalculateArithmic(numbers);
        }

        static int CalculateArithmic(int[] num)
        {
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {

                result += num[i];
               
            }

            return result / num.Length;
        }
    }
}
