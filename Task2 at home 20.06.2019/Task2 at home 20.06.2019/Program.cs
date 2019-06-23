using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_at_home_20._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Salam Tural necesen isler nece gedir";
            int a = emptiness(message);
            Console.WriteLine(a);
        }

        static int emptiness(string str)
        {
            int count=0;

            foreach (var i in str)
            {
                if(i == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
