using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga juhtub homme (Kasutame Random klassi)


            string[] predictions = { "win a milliong", "fall in love", "buy youtube premium", "join the darkside for cookies" };
            Random rnd = new Random();

            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tommorow you will {predictions[userNumber]}");
            Console.WriteLine("Kena päeva jätkU!");







        }
    }
}
