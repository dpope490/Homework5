using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence without punctuation: ");
            String sentence = Console.ReadLine();
            string[] words = sentence.Split();

            var distinctWords = from word in words
                                orderby word ascending
                                select word.ToLower(); ;

            Console.WriteLine("\nDistinct words in sentence in alphabetical order: ");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (string word in distinctWords.Distinct())
            {
                Console.WriteLine("- " + word);
            }
            Console.WriteLine("\nEnter any key to end program");
            Console.ReadKey();
        }
    }
}
