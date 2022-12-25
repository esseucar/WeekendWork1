//Girilen 4 haneli bir tam sayının yüzler hanesindeki sayı degerinin 3 ile bölümünden elde edilen kalanın aynı sayının birler hanesindeki deger ile farkını bulan programı yazın.
using System;

namespace fourDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read 4-digit integer from the user
            Console.Write("Enter a 4-digit integer: ");
            int number = int.Parse(Console.ReadLine());

            // Extract the hundreds digit and the ones digit
            int hundredsDigit = (number / 100) % 10;
            float hundredDigit = hundredsDigit % 3f;
            int onesDigit = number % 10;
            

            // Calculate the difference 
            float difference = Convert.ToInt32(hundredDigit) - Convert.ToInt32(onesDigit) ;

            // Print the difference to the console
            Console.WriteLine("The difference : " + difference);
            Console.ReadKey();
        }
    }
}
