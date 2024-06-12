// see https://www.hackerrank.com/challenges/beautiful-binary-string/problem for details
using System;

/*
 * Alice has a binary string. She thinks a binary string is beautiful if and only if it doesn't contain the substring "010".

    In one step, Alice can change a  to a  or vice versa. Count and print the minimum number of steps needed to make Alice see the string as beautiful.

    Example
    b = 010


    She can change any one element and have a beautiful string.

    Function Description

    Complete the beautifulBinaryString function in the editor below.

    beautifulBinaryString has the following parameter(s):

    string b: a string of binary digits
    Returns

    int: the minimum moves required
    
    Input Format

    The first line contains an integer , the length of binary string.
    The second line contains a single binary string b.

    Output Format

    Print the minimum number of steps needed to make the string beautiful.

    Sample Input 0
    STDIN       Function
    -----       --------
    7           length of string n = 7
    0101010     b = '0101010'
    
    Sample Output 0
    2  

    Sample Input 1
    5
    01100

    Sample Output 1
    0

 */

namespace BeautifulBinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();

            Console.Write((B.Length - B.Replace("010", "").Length) / 3);
        }
    }
}
