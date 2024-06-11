using System.Collections.Generic;
using System.Linq;

namespace MissingWords
{
    internal static class Words
    {
        public static string[] FindMissingWords(string s, string t)
        {
            var initialPhrase = s.Split(' ');
            var derivadePhrase = t.Split(' ');
            var initialPhraseLength = initialPhrase.Length;
            Stack<string> wordsMissing = new Stack<string>();

            for (int i = 0; i < initialPhraseLength; i++)
            {
                var word = initialPhrase[i];
                if (!derivadePhrase.Contains(word))
                    wordsMissing.Push(word);
            }

            return wordsMissing.ToArray();
        }
    }
}
