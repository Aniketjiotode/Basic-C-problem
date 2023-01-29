using System;

namespace PrimeFactor
{
    internal class Prime_Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find prime factor");
            int n=int.Parse(Console.ReadLine());
            int number = n;
            for (int i = 2; number >= i * i; i = i)
            {
                if(number%i==0)
                {
                    Console.WriteLine(i);
                    number=number/i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(number);
        }
    }
}
