using System;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elso szam");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("muveleti jel");
            string c = Console.ReadLine();

            Console.WriteLine("masodik szam");
            int b = int.Parse(Console.ReadLine());

            string formula = "acb";
            formula = formula.Replace("a", a.ToString()).Replace("b", b.ToString()).Replace("c", c.ToString());

            var calc = new System.Data.DataTable();
            Console.WriteLine($"{a}{c}{b}={calc.Compute(formula, "")}");
        }
    }
}
