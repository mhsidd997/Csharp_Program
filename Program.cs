using System;

namespace NumberArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of Numebr list to be sorted..");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];
            int temp = 0;

            Console.WriteLine("\nPlease enter numbers to be sorted, Press enter to submit each number..");

            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNumber List Before Sorted:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nNumber list in Ascending Order:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("\n\nNumber list in Descending Order:");
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
