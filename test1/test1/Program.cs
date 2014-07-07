using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sheetal";
            object obj = str as string;
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
