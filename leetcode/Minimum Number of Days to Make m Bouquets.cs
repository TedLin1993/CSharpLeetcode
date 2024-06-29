namespace CSharpLeetcode.leetcode;

public class _1482
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        long sum = (long)m * k;
        if (sum > bloomDay.Length) return -1;
        var left = bloomDay[0];
        var right = bloomDay[0];
        foreach (var day in bloomDay)
        {
            left = Math.Min(left, day);
            right = Math.Max(right, day);
        }
        bool Check(int day)
        {
            var cur = 0;
            var consequence = 0;
            for (int i = 0; i < bloomDay.Length; i++)
            {
                if (bloomDay[i] <= day)
                {
                    consequence++;
                    if (consequence == k)
                    {
                        cur++;
                        consequence = 0;
                    }
                }
                else
                {
                    consequence = 0;
                }
            }
            return cur >= m;
        }
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (Check(mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}