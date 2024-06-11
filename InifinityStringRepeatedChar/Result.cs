namespace InifinityStringRepeatedChar
{
    class Result
    {
        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long repeatedString(string s, long n)
        {
            long repeatedCharNumber = 0;

            if (string.IsNullOrWhiteSpace(s)) return 0;

            int stringLenght = s.Length;
            if (stringLenght == 1)
            {
                return s.Equals("a", StringComparison.CurrentCultureIgnoreCase) ? n : repeatedCharNumber;
            }

            long lenghtRatio = n / stringLenght;
            long remainingLengh = n - (lenghtRatio * stringLenght);

            for (int index = 0; index < stringLenght; index++)
            {
                if (s[index] == 'a')
                {
                    repeatedCharNumber++;
                }
            }

            repeatedCharNumber = repeatedCharNumber * lenghtRatio;

            for (int index = 0; index < remainingLengh; index++)
            {
                if (s[index] == 'a')
                {
                    repeatedCharNumber++;
                }
            }

            return repeatedCharNumber;

        }

    }
}
