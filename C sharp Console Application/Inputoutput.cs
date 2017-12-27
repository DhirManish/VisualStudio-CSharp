using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = 5;

            List<String> val = new List<string>();

            for (int i=1; i <= parameter; i++)
            {
               
                val.Add(Console.ReadLine());

            }

            foreach(String values in val)
            {
                Console.Write(values);
            }
            

            Console.ReadLine();
        }
    }
}
