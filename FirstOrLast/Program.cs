using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //Programm kuvab kumb nendes on pikem, kas ees või perekonnanimi

            Console.WriteLine("Palun sisesta enda eesnimi.");
            string userName = Console.ReadLine();
            Console.WriteLine("Palun sisesta enda perekonnanimi.");
            string userSurname = Console.ReadLine();

            int userNameLength = userName.Length;
            int userSurnameLength = userSurname.Length;

            if (userNameLength > userSurnameLength)
            {
                Console.WriteLine("Teie eesnimi on pikem kui perekonnanimi");
            }
            else if (userNameLength < userSurnameLength)
            {
                Console.WriteLine("Teie perekonnanimi on pikem kui eesnimi");
            }
            else
            {
                Console.WriteLine("Teie eesnimi ja perekonnanimi on sama pikad");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
