using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i<=100; i++)
            {
                if (i % 3 == 0 & i % 5 == 0 )
                {
                    Console.Write(i);
                    Console.Write("\n");
                }

            }
            Console.ReadLine();
        }
    }
}
