using System;

namespace swapnumber
{
    internal class Swap_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;       
            b = a - b;     
            a = a - b;  
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
