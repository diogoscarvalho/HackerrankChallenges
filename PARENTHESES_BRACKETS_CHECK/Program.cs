using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARENTHESES_BRACKETS_CHECK
{
    class Program
    {

        /*
         * PARENTHESES / BRACKETS CHECK (HACKER RANK INTERVIEW QUESTIONS)
            Match the braces and verify weather all the opening braces has the closing braces in right order.

            Input: String of braces only: “[{}]()[{{()}}()]”
            Output: Yes

            Input: String of braces only: “[{}]({{()}}()]”
            Output: No

            So the basic approach would be to use stack to verify the correct order of braces.

            Iterate over each braces from start to end and do the below step at each iteration.

            Step 1.  When you find opening bracket: Do Push.
            Step 2.  When you find closing bracket: Do pop and check whether closing and opening bracket match. If yes, then continue, if not then break and return NO.
         * */

        static void Main(string[] args)
        {
            //var match = braces(new string[] { "[{}]()[{{()}}()]", "[{}]({{()}}()]" });
           // foreach(var item in match)
            //    Console.WriteLine(item);

            Console.WriteLine(checkBraces("[{}]()[{{()}}()]"));
            Console.WriteLine(checkBraces("[{}]({{()}}()]"));
            Console.Read();

        }

        static string checkBraces(string value)
        {
            Stack<char> specialCharStack = new Stack<char>();
            string response = "Fail";
            char tempChar;
            List<char> openingBracesList = new List<char>() { '[', '(', '{' };
            List<char> closingBracesList = new List<char>() { ']', ')', '}' };
            int valueLength = value.Length;

            if (value == null)
                return response;
            else if (valueLength == 0)
                response = "Pass";
            else
            {
                for (int i = 0; i < valueLength; i++)
                {
                    tempChar = value[i];

                    if (openingBracesList.Contains(tempChar))
                    {
                        specialCharStack.Push(tempChar);
                    }
                    else if (closingBracesList.Contains(tempChar))
                    {
                        if (specialCharStack.Count() > 0)
                        {
                            if (tempChar == ')' && '(' != specialCharStack.Pop())
                            {
                                return response;
                            }
                            else if (tempChar == '}' && '{' != specialCharStack.Pop())
                            {
                                return response;
                            }
                            else if (tempChar == ']' && '[' != specialCharStack.Pop())
                            {
                                return response;
                            }
                        }
                        else
                        {
                            return response;
                        }
                    }
                    else
                    {
                        return response;
                    }
                }

            }

            if (specialCharStack.Count == 0)
            {
                response = "Pass";
                return response;
            }
            else
            {
                return response;
            }
        }

        static string[] braces(string[] values)
        {
            var arrayString = new List<string> { "()", "[]", "{}" };
            string[] collection = new string[values.Count()];
            var match = string.Empty;
            var contador = 0;
            foreach (var item in values)
            {
                for (int i = 0; i < item.Length - 1; i += 2)
                {
                    match = item.Substring(i, 2);
                    if (!arrayString.Contains(match))
                    {
                        collection[contador] = "NO";
                        break;

                    }
                }
                if (string.IsNullOrEmpty(collection[contador]))
                {
                    collection[contador] = "YES";
                }
                contador++;
            }
            return collection;
        }

        //https://www.hackerrank.com/domains?h_r=hrw&h_v=default


    }
}
