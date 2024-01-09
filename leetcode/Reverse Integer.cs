namespace CSharpLeetcode.leetcode;
public class _7
{
    public int Reverse(int x)
    {
        long res = 0;
        while (x != 0)
        {
            res = res * 10 + x % 10;
            if (res > int.MaxValue || res < int.MinValue) return 0;
            x /= 10;
        }
        return (int)res;
    }
}