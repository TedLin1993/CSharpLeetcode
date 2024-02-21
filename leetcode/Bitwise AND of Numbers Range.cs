namespace CSharpLeetcode.leetcode;

public class _201
{
    public int RangeBitwiseAnd(int left, int right)
    {
        var maxBit = (int)Math.Log(right, 2);
        var res = 0;
        for (int i = maxBit; i >= 0; i--)
        {
            var mask = 1 << i;
            if ((mask & left) == (mask & right))
            {
                res |= mask & left;
            }
            else
            {
                break;
            }
        }
        return res;
    }
}