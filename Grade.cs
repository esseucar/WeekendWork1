
// Bir ders için yapılan iki ara sınav ve bir genel sınav sonucu değerlendirilerek geçme notları hesaplanacaktır.
//Bu dersin geçme notu 1. ara sınav notunun %20’si, 2. ara sınav notunun %30’u ve genel sınav notunun %50’si toplanarak 
//hesaplanmaktadır. Geçme notunu hesaplayan ve sonucu ekrana yazdıran programı yazın.
using System;
namespace PassingGrade
{   
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for midterm grades and final exam grade
            Console.WriteLine("midterm1");
            double midterm1 = double.Parse(Console.ReadLine());
            Console.WriteLine("midterm2");
            double midterm2 = double.Parse(Console.ReadLine());
            Console.WriteLine("finalExam");
            double finalExam = double.Parse(Console.ReadLine());

            // Calculate passing grade
            double passingGrade = (midterm1 * 0.2) + (midterm2 * 0.3) + (finalExam * 0.5);

            // Print passing grade to the console
            Console.WriteLine("The passing grade is: " + passingGrade);
            Console.ReadKey();

        }
    }
}
