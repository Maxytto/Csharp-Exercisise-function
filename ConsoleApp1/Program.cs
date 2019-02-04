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
            Console.WriteLine(IsPrimal(5));
 Console.WriteLine(IsPrimal(6));
            Console.ReadKey();
        }
        
        
        static bool IsPrimal(int sk)
        {
            for(int i = 2; i < sk; i++)
            {
                if(sk%i==0)
                {
                    return false;
                }
            }
                return true;
        }

    }
}
