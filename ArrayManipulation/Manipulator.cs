namespace ArrayManipulation
{
    internal static class Manipulator
    {
        public static long ArrayManipulation(int n, List<List<int>> queries)
        {
            int[] result = new int[n + 1];

            for (int index = 0; index < queries.Count; index++)
            {
                int firstIndex = queries[index][0];
                int lastIndex = queries[index][1];
                int numberToInsert = queries[index][2];

                int auxIndex = firstIndex;

                while (auxIndex <= lastIndex)
                {
                    result[auxIndex] += numberToInsert;
                    auxIndex++;
                }
            }

            return result.Max();
        }

        public static long ArrayManipulation2(int n, List<List<int>> queries)
        {
            long firstIndex, lastIndex, numToAdd, sum = 0, max = 0;

            // Create and initialize array
            long[] a = new long[n + 1];

            for (int i = 0; i < queries.Count; i++)
            {
                firstIndex = queries[i][0];
                lastIndex = queries[i][1];
                numToAdd = queries[i][2];

                // Apply the range update
                a[firstIndex] += numToAdd;
                if ((lastIndex + 1) <= n) a[lastIndex + 1] -= numToAdd;
            }

            for (int i = 1; i <= n; i++)
            {
                sum += a[i];
                if (max < sum) max = sum;
            }

            // Output the result
            return max;
        }

        
    }

}
