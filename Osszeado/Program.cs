using System;

namespace Osszeado
{
    class Program
    {
        static void Main(string[] args)
        {
            var semmi = 0;
            int szam;
            int osszead;
            do
            {
                szam = int.Parse(Console.ReadLine());
                if (szam != 0)
                {
                   osszead = semmi + szam;
                }
                else

            } while (szam != 0);
        }
    }
}