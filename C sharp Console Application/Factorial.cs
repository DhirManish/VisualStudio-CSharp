using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Factorial
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int total = number;

            for(int i=1; i<= number; i++)
            {
                total = total * (number - 1);

                number = number - 1;

            }

            Console.Write("Factotial of number is " + total);

            Console.ReadLine();

        }
    }
}
