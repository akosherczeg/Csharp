using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var szamFirst = random.Next(1, 10);
            var szamSecond = random.Next(1, 10);
            var szamThird = random.Next(1, 10);
            int leadottTippek = 0;
            int tippszam;

            do
            {
                leadottTippek++;
                Console.WriteLine($"Add meg az {leadottTippek}. tipped");
                while ((!int.TryParse(Console.ReadLine(), out tippszam)) || 0 > tippszam || 999 < tippszam)
                {
                    Console.WriteLine("Hibas formatum add meg ujra!");
                }

                int tippFirst = tippszam;
                int tippSecond = tippszam;
                int tippThird = tippszam;
                
                tippFirst /= 100;
                tippSecond /= 10;
                while (tippSecond >= 10)
                {
                    tippSecond -= 10;
                }
                while (tippThird >= 10)
                {
                    tippThird -= 10;
                }
                if (tippThird == szamThird && tippFirst == szamFirst && tippSecond == szamSecond)
                {
                    Console.WriteLine($"Nyertel {leadottTippek}. lépésbol");
                    return;
                }

                if (tippFirst > szamFirst)
                    Console.WriteLine($"Elso szam kisebb mint {tippFirst}");
                else if (tippFirst < szamFirst)
                    Console.WriteLine($"Elso szam nagyobb mint {tippFirst}");
                else
                    Console.WriteLine($"Elso szam talált {tippFirst}!");

                if (tippSecond > szamSecond)
                    Console.WriteLine($"Masodik szam kisebb mint {tippSecond}");
                else if (tippSecond < szamSecond)
                    Console.WriteLine($"Masodik szam nagyobb mint {tippSecond}");
                else
                    Console.WriteLine($"Masodik szam talált {tippSecond}!");

                if (tippThird > szamThird)
                    Console.WriteLine($"Harmadik szam kisebb mint {tippThird}");
                else if (tippThird < szamThird)
                    Console.WriteLine($"Harmadik szam nagyobb mint {tippThird}");
                else
                    Console.WriteLine($"Harmadik szam talált {tippThird}!");
            } while (true);
        }
    }
}