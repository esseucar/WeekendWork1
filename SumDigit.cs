using System;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 6 digit number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
            Console.ReadKey();

        }
    }
}
