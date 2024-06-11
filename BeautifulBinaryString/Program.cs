using System;

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
