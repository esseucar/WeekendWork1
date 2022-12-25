//Klavyeden girilen A ve B gibi iki sayıyı,  sadece toplama ve çıkarma işlemlerini kullanarak 
//(direkt çarpma işlemi kullanmadan) çarpma işlemini yapan ve bunun sonucunu ekrana, 
//ekranın geri plan rengi beyaz ve ekrana yazılan mesajın rengi kırmızı olacak 
//şekilde yazan programı yazınız.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Read num A and B nums
            Console.WriteLine("Enter A Number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B Number");
            int B = int.Parse(Console.ReadLine());
            int res = 0;
            for(int i=1; i <= B; i++)
            {
                res = res+A;
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(res);
            Console.ReadKey();

             
        }
    }
}
