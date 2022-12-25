using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the amount of money you want to withdraw: ");
            int amount = int.Parse(Console.ReadLine());

            
            int num200s = amount / 200;
            amount = amount % 200;
            int num100s = amount / 100;
            amount = amount % 100;
            int num50s = amount / 50;
            amount = amount % 50;
            int num20s = amount / 20;
            amount = amount % 20;
            int num10s = amount / 10;
            amount = amount % 10;
            int num5s = amount / 5;

            // Print the number of each banknote
            Console.WriteLine("200's: " + num200s);
            Console.WriteLine("100's: " + num100s);
            Console.WriteLine("50's: " + num50s);
            Console.WriteLine("20's: " + num20s);
            Console.WriteLine("10's: " + num10s);
            Console.WriteLine("5's: " + num5s);
            Console.ReadKey();
        }
    }
}