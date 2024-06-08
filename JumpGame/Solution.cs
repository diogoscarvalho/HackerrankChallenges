namespace JumpGame
{
    internal static class Solution
    {
        public static bool CanJump(int[] nums)
        {

            int target = nums.Length - 1;

            for (int index = (nums.Length - 1); index >= 0; index--)
            {
                if (nums[index] + index >= target)
                {
                    target = index;
                }
            }

            if (target == 0) return true;

            return false;
        }

        public static bool CanJump2(int[] nums)
        {
            int maxReach = 0;

            for (int index = (nums.Length - 1); index >= 0; index--)
            {
                if (index > maxReach) return false;

                maxReach = Math.Max(maxReach, nums[index] + index);
            }

            return true;
           
        }

    }
}
