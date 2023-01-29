using System;

namespace Largest_number
{
    internal class Largest_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write($"{num1} is the largest!");
                }
                else
                {
                    Console.Write($"{num3} is the largest!");
                }
            }
            else if (num2 > num3)
            {
                Console.Write($"{num2} is the largest!");
            }
            else
            {
                Console.Write($"{num3} three is the largest!");
            }

        }
    }
}
