namespace CSharpLeetcode.leetcode
{
    public class House_Robber_IV
    {
        public int MinCapability(int[] nums, int k)
        {
            var left = nums[0];
            var right = nums[0];
            foreach (var num in nums[1..])
            {
                left = Math.Min(left, num);
                right = Math.Max(right, num);
            }
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (mid >= nums[i])
                    {
                        count++;
                        i++;
                    }
                }
                if (count < k) left = mid + 1;
                else right = mid;
            }
            return right;
        }
    }
}