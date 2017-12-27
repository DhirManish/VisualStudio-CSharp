using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "*";

            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(s);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
