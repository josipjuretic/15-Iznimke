using System;

namespace Vsite.CSharp
{
    // ispis tijeka izvoðenja try-catch-finally bloka
    class Program
    {
        static void Main(string[] args)
        {
            int[] djeljitelji = new int[] { 1, 2, 0 };

            for (int i = 0; i < djeljitelji.Length; ++i)
            {
                // Donje naredbu umetnuti u try-blok te dodati catch i finally blokove. Dodati kontrolne ispise u svaki od tih blokova te provjeriti što æe se ispisati. Ispisi prekopirati u "TijekIzvodjenja.txt"
                try
                {
                    Console.WriteLine("Dijelim s {0}", djeljitelji[i]);
                    Console.WriteLine(3 / djeljitelji[i]);
                    Console.WriteLine("Podijelio sam s {0}", djeljitelji[i]);

                }

                catch
                {
                    Console.WriteLine("Iznimka uhvaæema");
                }

                finally
                {
                    Console.WriteLine("Finale");
                }

                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
