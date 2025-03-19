namespace CSharpLeetcode.leetcode;

public class _1011
{
    public int ShipWithinDays(int[] weights, int days)
    {
        var max = 0;
        var sum = 0;
        foreach (var w in weights)
        {
            sum += w;
            max = Math.Max(max, w);
        }
        var left = max - 1;
        var right = sum;
        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;
            var count = 0;
            var cur = 0;
            foreach (var w in weights)
            {
                if (cur + w <= mid)
                {
                    cur += w;
                }
                else
                {
                    count++;
                    cur = w;
                }
            }
            if (cur > 0) count++;

            if (count <= days)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }
        return right;
    }
}