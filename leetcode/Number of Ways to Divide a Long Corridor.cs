namespace CSharpLeetcode.leetcode;
public class NumberofWaystoDivideaLongCorridor
{
    public int NumberOfWays(string corridor)
    {
        var n = corridor.Length;
        var mod = (long)1e9 + 7;
        var sCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (corridor[i] == 'S') sCount++;
        }
        if (sCount < 2) return 0;
        if (sCount == 2) return 1;
        if (sCount % 2 == 1) return 0;
        long res = 1;
        var curS = 0;
        var splitCount = 1;
        for (int i = 0; i < n; i++)
        {
            if (corridor[i] == 'S')
            {
                if (curS < 2)
                {
                    curS++;
                }
                else
                {
                    res *= splitCount;
                    res %= mod;
                    splitCount = 1;
                    curS = 1;
                }
            }
            else
            {
                if (curS < 2)
                {
                    continue;
                }
                else
                {
                    splitCount++;
                }
            }
        }
        return (int)res;
    }
}