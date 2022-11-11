using System;

namespace Swapping_W_WO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two number to swap...");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nNumber before swapping: x = {x}\ty = {y}");
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"\nNumber after swapping: x = {x}\ty = {y}\n");
            Console.WriteLine("\nPlease enter two number to swap without using temp variable...");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nNumber before swapping: x = {a}\ty = {b}");
            Console.WriteLine($"\nNumber after swapping: x = {(a*b)/a}\ty = {(a*b)/b}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
