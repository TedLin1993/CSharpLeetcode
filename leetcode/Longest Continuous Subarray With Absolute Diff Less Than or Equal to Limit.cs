namespace CSharpLeetcode.leetcode;

public class _1438
{
    public int LongestSubarray(int[] nums, int limit)
    {
        var n = nums.Length;
        var incDeq = new LinkedList<int>();
        var decDeq = new LinkedList<int>();

        var left = 0;
        var right = 0;
        var res = 1;
        while (right < n)
        {
            while (incDeq.Count > 0 && nums[right] < nums[incDeq.Last.Value])
            {
                incDeq.RemoveLast();
            }
            incDeq.AddLast(right);

            while (decDeq.Count > 0 && nums[right] > nums[decDeq.Last.Value])
            {
                decDeq.RemoveLast();
            }
            decDeq.AddLast(right);

            while (nums[decDeq.First.Value] - nums[incDeq.First.Value] > limit)
            {
                left++;
                if (decDeq.First.Value < left) decDeq.RemoveFirst();
                if (incDeq.First.Value < left) incDeq.RemoveFirst();
            }
            res = Math.Max(res, right - left + 1);
            right++;
        }
        return res;
    }
}