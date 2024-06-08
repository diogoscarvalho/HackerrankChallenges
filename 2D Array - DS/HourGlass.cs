namespace TwoDArrayDS
{
    internal class HourGlass
    {
        public static int Sum(List<List<int>> arr)
        {
            int maxSum = int.MinValue;
            arr.Reverse();

            for (int rowIndex = 0; rowIndex < arr.Count; rowIndex++)
            {
                if (rowIndex + 3 <= arr.Count)
                {
                    var columnIndex = 0;

                    while (columnIndex + 3 <= arr.Count)
                    {
                        var hourGlassSum = (arr[rowIndex][columnIndex] + arr[rowIndex][columnIndex + 1] + arr[rowIndex][columnIndex + 2])
                                            + arr[rowIndex + 1][columnIndex + 1]
                                            + (arr[rowIndex + 2][columnIndex] + arr[rowIndex + 2][columnIndex + 1] + arr[rowIndex + 2][columnIndex + 2]);
                        
                        if (maxSum < hourGlassSum) maxSum = hourGlassSum;

                        columnIndex++;
                    }
                }
            }

            return maxSum;
        }
    }
}
