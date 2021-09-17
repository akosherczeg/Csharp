using System;

namespace FizzBuzz
{
    class Program
         
    {
        static void FizzBuzz (int a)
        {
            if (a % 3 == 0)
                Console.Write("Fizz");
            else if (a % 5 == 0)
                Console.Write("Buzz");
            else
                Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            FizzBuzz(a);
        }
    }
}
