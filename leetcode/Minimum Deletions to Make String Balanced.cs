namespace CSharpLeetcode.leetcode;

public class _1653
{
    public int MinimumDeletions(string s)
    {
        var n = s.Length;
        var totalBCount = s.Count(c => c == 'b');
        var res = n - totalBCount;
        var bCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'b') bCount++;

            var delACount = n - i - 1 - (totalBCount - bCount);
            res = Math.Min(res, bCount + delACount);
        }
        return res;
    }
}