namespace MergeSortedArray
{
    internal static class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;
            int len1 = nums1.Length;
            int end_idx = len1 - 1;
            while (n > 0 && m > 0)
            {
                if (nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[end_idx] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[end_idx] = nums1[m - 1];
                    m--;
                }
                end_idx--;
            }
            while (n > 0)
            {
                nums1[end_idx] = nums2[n - 1];
                n--;
                end_idx--;
            }
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != val)
                    nums[k++] = nums[i];

            return k;
        }
        public static int RemoveDuplicates(int[] nums)
        {
            var position = 1;
            var numberOfDuplicates = 0;

            for (int index = 1; index < nums.Length; index++)
            {
                numberOfDuplicates = nums[index] == nums[index - 1]
                    ? numberOfDuplicates + 1
                    : 0;

                if (numberOfDuplicates < 2)
                {
                    nums[position++] = nums[index];
                }
            }

            return position;
        }

    }
}
