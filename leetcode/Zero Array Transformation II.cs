namespace CSharpLeetcode.leetcode;

public class _3356
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        var n = nums.Length;
        bool Search(int index)
        {
            var start = new int[n + 1];
            for (int i = 0; i < index; i++)
            {
                var q = queries[i];
                start[q[0]] += q[2];
                start[q[1] + 1] -= q[2];
            }
            var cur = 0;
            for (int i = 0; i < n; i++)
            {
                cur += start[i];
                if (nums[i] > cur) return false;
            }
            return true;
        }

        var left = -1;
        var right = queries.Length + 1;
        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;
            if (Search(mid))
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }

        return right > queries.Length ? -1 : right;
    }
}