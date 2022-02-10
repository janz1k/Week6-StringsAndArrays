using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi


            string tereMaailm = "Hello, World!";

            for (int i = tereMaailm.Length - 1; i >= 0; i--)
            {
                Console.Write(tereMaailm[i]);
            }


        }
    }
}
