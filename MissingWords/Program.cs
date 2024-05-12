using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingWords
{
    class Program
    {
        static void Main(string[] args)
        {

            var missingWordsResult = missingWords("I am using HackerRank to improve programming", "am HackerHank to improve");

            foreach (var word in missingWordsResult)
            {
                Console.WriteLine(word);
            }

            Console.Read();
        }

        public static string[] missingWords(string s, string t)
        {
            var initialPhrase = s.Split(' ');
            var derivadePhrase = t.Split(' ');
            var initialPhraseLength = initialPhrase.Length;
            var missingWords = new List<string>();
            Stack<string> wordsMissing = new Stack<string>();

            for (int i = 0; i < initialPhraseLength; i++)
            {
                var word = initialPhrase[i];
                if (!derivadePhrase.Contains(word))
                    wordsMissing.Push(word);
            }

            return missingWords.ToArray();
        }
    }
}
