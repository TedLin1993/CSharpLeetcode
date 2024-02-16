namespace CSharpLeetcode.leetcode;

public class _1481
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var n = arr.Length;
        var dictNumCount = new Dictionary<int, int>();
        foreach (var v in arr)
        {
            dictNumCount[v] = dictNumCount.GetValueOrDefault(v) + 1;
        }
        var counts = new int[k + 1];
        foreach (var kvp in dictNumCount)
        {
            if (kvp.Value <= k)
            {
                counts[kvp.Value]++;
            }
        }
        var res = dictNumCount.Count;
        for (int i = 1; i <= k; i++)
        {
            if (k >= i * counts[i])
            {
                k -= i * counts[i];
                res -= counts[i];
            }
            else
            {
                return res - k / i;
            }
        }
        return res;
    }
}