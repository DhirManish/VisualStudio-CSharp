using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Flag = false;
            int a = 0;
            int b = 1;
            int c = 0;

            int limit = Int32.Parse(Console.ReadLine());

            Console.Write(a + " ");

            Console.Write(b + " ");

            for (int i = 1; i <= limit; i++)
            {
                
                c = a + b;

                Console.Write(c + " ");

                a = b;

                b = c;
                
            }

            Console.ReadLine();
        }
    }
}
