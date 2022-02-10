using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnimie pikkust

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnime pikkus on {firstNameLength} sümbolit"); //---> mõlemad samad viisid 
            Console.WriteLine($"Sinu eesnime pikkus on {firstName.Length} sümbolit"); //---> mõlemad samad viisid

        }
    }
}
