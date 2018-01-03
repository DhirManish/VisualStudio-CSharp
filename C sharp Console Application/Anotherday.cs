using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Anotherday
    {
        static void Main(string[] args)
        {

            for(int i=1; i<=12; i++)
            {
                for(int j=1; j<=12; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
