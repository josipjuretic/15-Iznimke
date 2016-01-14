using System;

namespace Vsite.CSharp
{
    // Primjer izvoðenja try-catch-finally kada je iznimka
    // baèena unutar pozvane metode
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Prije izvoðenja programa pokušati predvidjeti tok programa. Pokrenut program i provjeriti ispravnost pretpostavke
            try
            {
                Metoda1();
            }
            //// ako bismo ovo zakomentirali, unhandled exception!!!
            //catch (Exception e)
            //{
            //    Console.WriteLine("catch(Exception) u Main");
            //}
            finally
            {
                Console.WriteLine("finally u Main");
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static void Metoda1()
        {
            try
            {
                Metoda2();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("catch(ArgumentException) u Metoda1");
            }
            // Kako bi izgledalo izvoðenje programa kada bi se izostavio donji blok hvatanja? Zakomenirajte ga i pokrenite program. 
            catch (DivideByZeroException)
            {
              Console.WriteLine("catch(DivideByZeroException) u Metoda1");
            }
            finally
            {
                Console.WriteLine("finally u Metoda1");
            }
        }

        static void Metoda2()
        {
            int a = 5;
            int b = 0;
            try
            {
                // ovdje æe biti baèen DivideByZeroException!!!
                Console.WriteLine("Bacam Exception");
                Console.WriteLine(a / b);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("catch(NotSupportedException) u Metoda2");
            }
            finally
            {
                Console.WriteLine("finally u Metoda2");
            }
        }
    }
}
