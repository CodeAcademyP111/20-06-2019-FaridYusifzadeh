using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_at_home_20._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "Salam Ferid necesen qaqa ne var ne yox brat";

            Console.WriteLine(ternWords(words));
        }

        static string ternWords(string str)
        {

            string temp = "";

                for (int j = str.Length - 1; j >= 0; j--)
                {

                    temp += str[j];
                }

            return temp;

        }
    }
}
