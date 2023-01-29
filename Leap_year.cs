using System;

namespace Leap_year
{
    internal class Leap_year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine($"{Year} is a Leap Year");
            }
            else {

                Console.WriteLine($"{Year} is not a Leap Year");
                }
           
        }
    }
}
