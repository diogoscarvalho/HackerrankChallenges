using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingWords
{
    class Program
    {
        static void Main(string[] args)
        {

            var missingWordsResult = Words.FindMissingWords("I am using HackerRank to improve programming", "am HackerHank to improve");

            foreach (var word in missingWordsResult)
            {
                Console.WriteLine(word);
            }

            Console.Read();
        }

        
    }
}
