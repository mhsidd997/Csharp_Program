using System;
using System.Text;

namespace Sentence_Word_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to reverse the whole sentence in same place, if word has starting and end character same it will not reverse it.\n");
            Console.WriteLine("Enter a sentence... Press enter to submit.");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            StringBuilder @string = new StringBuilder();
            string rev;

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++\n");

            for (int i = 0; i <= words.Length - 1; i++)
            {
                rev = words[i];
                if (rev.ToLower()[0] != rev.ToLower()[rev.Length - 1])
                {
                    @string.Clear();
                    for (int j = rev.Length - 1; j >= 0; j--)
                    {
                        words[i] = @string.Append(rev[j]).ToString();
                    }
                }
                else
                {
                    words[i] = rev;
                }
                Console.Write(words[i] + ' ');
            }
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
