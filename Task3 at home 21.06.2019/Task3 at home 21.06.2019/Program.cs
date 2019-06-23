using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_at_home_21._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = "Shahveled";
            lettersCount(letter);
        }

        static void lettersCount(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[j] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(str[i]+ " : " + count);
            }
        }
    }
}
