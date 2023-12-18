namespace CSharpLeetcode.leetcode;

public class Apply_Operations_to_Maximize_Frequency_Score
{
    public int MaxFrequencyScore(int[] nums, long k)
    {
        Array.Sort(nums);
        var n = nums.Length;
        var preSum = new long[n + 1];
        for (int i = 0; i < n; i++)
        {
            preSum[i + 1] = preSum[i] + nums[i];
        }
        long getDistance(int left, int right)
        {
            var midIdx = (right + left) / 2;
            var mid = nums[midIdx];
            var leftSum = mid * (midIdx - left) - (preSum[midIdx] - preSum[left]);
            var rightSum = preSum[right + 1] - preSum[midIdx + 1] - mid * (right - midIdx);
            return leftSum + rightSum;
        }
        var left = 0;
        var res = 0;
        for (int right = 0; right < n; right++)
        {
            while (getDistance(left, right) > k)
            {
                left++;
            }
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}