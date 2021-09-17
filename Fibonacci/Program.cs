using System;

namespace Fibonacci
{
    class Program
    {
        static void Fibonacci(int a)
        {
            int first = 9;
            int second = -5;
            int third = 0;
            for (int i = 2; i < a; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }
            Console.WriteLine(third);
        } 
        static void Main(string[] args)
        {
            Fibonacci(30);
        }
    }
}
