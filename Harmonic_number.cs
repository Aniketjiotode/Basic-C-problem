using System;

namespace Harmonic
{
    internal class Harmonic_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number");

            int N = int.Parse(Console.ReadLine());
            float harmonic = 1;


            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }

            Console.WriteLine(+N+"th Harmonic number is = "+harmonic);

        }



    }
}
    

