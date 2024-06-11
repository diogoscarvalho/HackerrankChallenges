namespace NewYearChaos
{
    internal static class Bribe
    {
        /* Wrong solution */
        public static void MinimumBribes(List<int> q)
        {
            for (int index = 0; index < q.Count; index++)
            {
                if (q[index] - (index + 1) > 2) { Console.WriteLine("Too chaotic"); return; }
            }

            int totalBribes = 0;
            for (int index = 0; index < q.Count; index++)
            {
                if (q[index] - (index + 1) > 0)
                    totalBribes += q[index] - (index + 1);
            }

            Console.Write(totalBribes);
        }

        /* Correct solution */
        public static void Bribes(List<int> q)
        {
            int bribes = 0;
            for (int i = 0; i < q.Count; i++)
            {
                // Check if the position moved more than 2 positions (meaning, bribed more than 2 people)
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return; 
                }

                // I want to compare the current position/person to see how many bribes this person received
                // In order to do that, I need to compare the current position with the previous ones
                // i.e. If my first cursor is in the position 4 but my current number is 3, I need to compare its value with the previous starting in the position 2 (the expected place of this person before have received bribe(s))
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    // If my current possition(cursor i) has a number less than the previous, that means that it has received a bribe.
                    if (q[j] > q[i])
                    {
                        bribes++;
                    }
                }
            }
            
            Console.WriteLine(bribes);
        }
    }
}
