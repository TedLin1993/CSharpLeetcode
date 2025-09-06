namespace CSharpLeetcode.leetcode;

public class _2749
{
    public int MakeTheIntegerZero(int num1, int num2)
    {
        for (int i = 1; i <= 64; i++)
        {
            var v = num1 - (long)num2 * i;
            if (v < 1) return -1;
            if (long.PopCount(v) <= i && v >= i) return i;
        }

        return -1;
    }
}