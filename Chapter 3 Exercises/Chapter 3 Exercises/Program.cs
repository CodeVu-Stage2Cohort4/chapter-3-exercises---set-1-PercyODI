using System;

namespace Chapter_3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
