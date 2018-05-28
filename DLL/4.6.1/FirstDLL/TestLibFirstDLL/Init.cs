using System;

namespace May29TestLibFirstDLL.TestLibFirstDLL
{

    using May29FirstDLL.FirstDLL;

    public class Init
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum.Add(10, 10));
            Console.ReadKey();
        }
    }
}
