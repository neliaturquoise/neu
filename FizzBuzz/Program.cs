using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string f = "Fizz";
            string b = "Buzz";
            for (i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    Console.Write(f);
                if (i % 5 == 0)
                    Console.Write(b);
                if (i % 3 != 0 && i % 5 != 0)
                    Console.Write(i);
                Console.WriteLine();
             }
            Console.ReadLine();
        }
    }
}
