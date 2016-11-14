/*
Roy wanted to increase his typing speed for programming contests.So, his friend advised him to type the sentence "The quick brown fox jumps over the lazy dog" repeatedly, because it is a pangram. (Pangrams are sentences constructed by using every letter of the alphabet at least once.)
After typing the sentence several times, Roy became bored with it.So he started to look for other pangrams.
Given a sentence , tell Roy if it is a pangram or not.
Input Format
Input consists of a string .
Constraints
Length of can be at most and it may contain spaces, lower case and upper case letters.Lower-case and upper-case instances of a letter are considered the same.
Output Format
Output a line containing pangram if  is a pangram, otherwise output not pangram.
    Sample Input
    Input #1
        We promptly judged antique ivory buckles for the next prize
    Input #2
        We promptly judged antique ivory buckles for the prize

Sample Output
    Output #1
        pangram
    Output #2
        not pangram

Explanation
In the first test case, the answer is pangram because the sentence contains all the letters of the English alphabet.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {

            var sentence = "We promptly judged antique ivory buckles for the next prize";
            var checkPangram = IsPangram(sentence);

            Console.Write(checkPangram);
            Console.ReadKey();
        }

        private static string IsPangram(string sentence)
        {
            var chars = GetalphabetLetters();
            var alphabetLength = chars.Length;
            var distinctsChars = new List<string>();

            var normalizedSentence = NormalizeSentence(sentence);
            var normalizedSentenceLength = normalizedSentence.Length;

            for(int i = 0; i < normalizedSentenceLength; i++)
            {
                var letter = normalizedSentence.Substring(i, 1);
                if (i == 0)
                    distinctsChars.Add(letter);
                else
                {
                    if(!distinctsChars.Contains(letter))
                        distinctsChars.Add(letter);
                }
            }

            if (distinctsChars.Count == alphabetLength)
                return "pangram";
            else
                return "not pangram";
        }

        private static string NormalizeSentence(string originalString)
        {
            originalString = RemoveNoLettersCaracters(originalString);

            return originalString.ToLower();
        }

        private static string RemoveNoLettersCaracters(string sentence)
        {
            var onlyLetters = string.Join(null, Regex.Split(sentence, "[^a-zA-Z]"));
            return onlyLetters;
        }

        private static char[] GetalphabetLetters()
        {
            var caracteresAlphabet = new char[] {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','x','w','y','z'
            };

            return caracteresAlphabet;
        }
    }
}
