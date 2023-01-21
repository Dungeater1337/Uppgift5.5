using System;

namespace Uppgift5_5
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hur många frågor villd du ställa?");
            int index = int.Parse(Console.ReadLine());
            int[] array = new int[index];
            string[] svar = { "Ja", "nej", "Kanske", "100%", "Svårt att säga", "Inte säkert", "Du skall få", "Gör det", "Gör inte det", "Oklart" };
            Random random= new Random();

            for(int i = 0; i < array.Length; i++)
            {
                int val = random.Next(svar.Length);
                Console.WriteLine("Skriv in din " + i + " fråga");
                string fråga = Console.ReadLine();
                Console.WriteLine("\n" + svar[val]);
            }
        }
    }
}