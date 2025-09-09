namespace CSharpLeetcode.leetcode;

public class _2327
{
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        var mod = (int)1e9 + 7;
        var born = new long[n];
        born[0] = 1;
        for (int i = 1; i < n; i++)
        {
            for (int j = i - delay; j >= 0 && j > i - forget; j--)
            {
                born[i] += born[j];
            }
            born[i] %= mod;
        }

        int res = 0;
        for (int i = 0; i < forget; i++)
        {
            res += (int)born[n - 1 - i];
            res %= mod;
        }
        return res;
    }
}