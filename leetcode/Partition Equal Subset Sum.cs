namespace CSharpLeetcode.leetcode
{
    public class Partition_Equal_Subset_Sum
    {
        public bool CanPartition(int[] nums)
        {
            var sum = nums.Sum();
            if (sum % 2 != 0) return false;
            var mid = sum / 2;
            var dp = new bool[mid + 1];
            dp[0] = true;
            foreach (var num in nums)
            {
                for (int i = mid; i >= num; i--)
                {
                    dp[i] = dp[i] | dp[i - num];
                }
            }
            return dp[mid];
        }
    }
}