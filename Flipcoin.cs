using System;

namespace Flipcoin
{
    internal class Flipcoin
    {
        static void Main(string[] args)
        {

            flipcoin();
        }

            static void flipcoin()
            {
            Console.WriteLine(" Enter number for number times to flip the coin");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            float heads = 0, tails = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = rnd.Next(2);
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Head");
                        heads++;
                        break;
                    case 1:
                        Console.WriteLine("Tail");
                        tails++;
                        break;
                }
            }

            float head_percentage = (heads / (tails + heads)) * 100;
            float tail_percentage = (tails / (tails + heads)) * 100;
            Console.WriteLine($"Head perctage = {head_percentage}%");
            Console.WriteLine($"Tail perctage = {tail_percentage}%");
            }
    }
}
