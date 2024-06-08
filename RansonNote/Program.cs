namespace TwoStrings
{
    /*
     * Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting. He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. The words in his note are case-sensitive and he must use only whole words available in the magazine. He cannot use substrings or concatenation to create the words he needs.

        Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.

        Example
        magazine = "attack at dawn" note = "Attack at dawn"

        The magazine has all the right words, but there is a case mismatch. The answer is .

        Function Description

        Complete the checkMagazine function in the editor below. It must print  if the note can be formed using the magazine, or .

        checkMagazine has the following parameters:

        string magazine[m]: the words in the magazine
        string note[n]: the words in the ransom note
        
        Prints
        string: either Yes or No. no return value is expected
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            RansonNote.CheckMagazine(["o", "l", "x", "imjaw", "bee", "khmla", "v", "o", "v", "o", "imjaw", "l", "khmla", "imjaw", "x",],
                ["imjaw", "l", "khmla", "x", "imjaw", "o", "l", "l", "o", "khmla", "v", "bee", "o", "o", "imjaw", "imjaw", "o"]);
            Console.ReadKey();
        }
    }
}
