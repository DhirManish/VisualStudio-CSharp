using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Enter the digit count limitator : ");

            int limit = Int32.Parse(Console.ReadLine());

            Console.Write(a + " ");

            Console.Write(b + " ");

            for (int i = 1; i <= limit; i++)
            {

                c = a + b;

                if(c % 2 == 0)
                {

                    Console.Write(c + " ");

                }

                a = b;

                b = c;

            }
            Console.ReadLine();
        }
    }
}
