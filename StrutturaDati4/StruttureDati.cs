using System;
using System.IO;

namespace StrutturaDati4
{
    class StruttureDati
    {
        static void Main(string[] args)
        {
            string test = "test.txt";
            Console.WriteLine("inserisci un numero:");
            string numero = Console.ReadLine();
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == numero)
                    {
                        Console.WriteLine($"il numero esiste");
                        Console.ReadLine();
                    }
                    else if (line != numero)
                    {
                        Console.WriteLine($"il numero non esiste");
                    }
                    Console.ReadLine();
                }
            }
        }
         
    }
}
