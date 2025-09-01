namespace CSharpLeetcode.leetcode;

public class _3668
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        var set = new bool[order.Length + 1];
        foreach (var f in friends)
        {
            set[f] = true;
        }

        var res = new int[friends.Length];
        var idx = 0;
        foreach (var o in order)
        {
            if (set[o])
            {
                res[idx] = o;
                idx++;
            }
        }

        return res;
    }
}