using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  

    class Classsample 
    {

        public string value()
        {

            String s = Console.ReadLine();
            return s;

        }

        static void Main(string[] args)
        {
            Classsample cs = new Classsample();

            Console.Write(cs.value());
            Console.Read();

           
        }
    }
}
