using System;

namespace Vsite.CSharp
{
    // Jednostavni primjer kako iznimke omogu�avaju odvajanje
    // glavne logike od hvatanja i oporavka 
    class Program
    {

        static int faktorjel(int broj)
        {
            // Dodati u metodu provjeru je li argument manji od 0 i u tom slu�aju baciti iznimku tipa ArgumentOutOfRangeException s odogovaraju�om porukom


            int rezultat = 1;
            for (int i = 2; i <= broj; ++i)
                rezultat *= i;
            return rezultat;
        }

        static void Main(string[] args)
        {
            // Provjeriti koju iznimku �e baciti metoda faktorjel u donjoj petlji te na osnovu toga...
            // Donje petlje obuhvatiti try-catch blokom koji �e prekinuti daljnje ra�unanje kada bude ba�ena iznimka
            try 
            {
                for (int n = 1; n < 20; ++n)
                {
                    for (int k = 1; k <= n; ++k)
                    {
                        int povrh = faktorjel(n) / (faktorjel(k) * faktorjel(n - k));
                        Console.WriteLine("{0} povrh  {1} = {2}", n, k, povrh);
                    }
                }
            }
            catch (OverflowException e)
                {

                Console.WriteLine(e.Message);
                }
            
    
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
