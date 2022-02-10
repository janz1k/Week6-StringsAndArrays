using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"


            string fullName = "Hello World!".ToLower();


            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;


            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'h')
                {
                    hCounter++;
                }
                if (fullName[i] == 'o')
                {
                    oCounter++;
                }
                if (fullName[i] == 'l')
                {
                    lCounter++;
                }


            }
            Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte");




        }
    }
}
