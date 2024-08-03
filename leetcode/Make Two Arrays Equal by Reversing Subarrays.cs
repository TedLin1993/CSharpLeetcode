namespace CSharpLeetcode.leetcode;

public class _1460
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var cnt = new int[1001];
        foreach (var v in target)
        {
            cnt[v]++;
        }
        foreach (var v in arr)
        {
            cnt[v]--;
            if (cnt[v] < 0) return false;
        }
        return true;
    }
}