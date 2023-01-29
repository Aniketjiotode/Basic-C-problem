using System;

namespace Firstproject
{
    internal class PowerOf2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the base value");
            int basev = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power");
            int power2b=int.Parse(Console.ReadLine());
            int power = power2b;

            int res = 1;
            while (power > 0)
            {
                res = res * basev;
                power--;

            }
                Console.WriteLine("power of " + basev + " with power " + power2b + " is " + res);
               
            

        } 

    }

}