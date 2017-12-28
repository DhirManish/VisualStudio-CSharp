using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassInitiater
{

    class ClassInitater
    {

        string s = "Coder";

        public string returnname ()
        {
            return s;
        }

    }

    class Program : ClassInitater
    {
        static void Main(string[] args)
        {

            ClassInitater CI = new ClassInitater();

            Console.Write(CI.returnname());

        }
    }
}
