using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Range(2, 1, 3));

            Console.ReadKey();

        }
        static int Range(int sk1, int sk2, int sk3)
        {
            if (sk1 > sk2 && sk1 < sk3)
            {
                return sk1;
            }
            else if (sk2 < sk3 && sk2 < sk1)
            {
                return sk2;
            }
            else
            {
                return sk3;
            }
        }


    }
}
