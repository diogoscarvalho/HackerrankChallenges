namespace JumpGameII
{
    internal static class Solution
    {
        public static int Jump(int[] nums)
        {
            int jumps = 0;
            int left = 0;
            int right = 0;

            while(right < nums.Length -1) 
            {
                int farthest = 0;
                for(int i = left; i <= right; i++)
                {
                    farthest = Math.Max(farthest, i + nums[i]);
                }

                left = right + 1;
                right = farthest;
                jumps += 1;
            }

            return jumps;
        }
    }
}
