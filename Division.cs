using System;

namespace Division
{
    internal class Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend number");
            int divid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor number");
            int diviso=int.Parse(Console.ReadLine());

            int Quotient = divid / diviso;
            int remainder= divid% diviso;
            Console.WriteLine("Quotient = "+Quotient+ " Remainder = " + remainder);
        }
    }
}
