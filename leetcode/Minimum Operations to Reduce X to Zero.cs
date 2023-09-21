namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int MinOperations(int[] nums, int x)
        {
            var n = nums.Length;
            var sum = nums.Sum();
            if (sum < x) return -1;
            if (sum == x) return n;
            var res = n;
            int left = 0;
            for (int i = 0; i < n; i++)
            {
                if (x < nums[i])
                {
                    left = i - 1;
                    break;
                }
                x -= nums[i];
            }
            if (x == 0) res = left + 1;
            int right = nums.Length - 1;
            while (right > left)
            {
                x -= nums[right];
                while (x < 0 && left >= 0)
                {
                    x += nums[left];
                    left--;
                }
                if (x == 0) res = Math.Min(res, left + n - right + 1);
                if (x < 0) break;
                right--;
            }

            if (res == n) return -1;
            return res;
        }
    }
}