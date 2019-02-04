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
            Console.WriteLine(Max(5,10,7));
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        static int Max(int sk1, int sk2, int sk3)
        {
            if (sk1 > sk2 && sk1 > sk3)
            {
                return sk1;
            }
            else if (sk2 > sk3 && sk2 > sk1)
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
