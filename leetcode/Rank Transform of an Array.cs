namespace CSharpLeetcode.leetcode;

public class _1331
{
    public int[] ArrayRankTransform(int[] arr)
    {
        if (arr.Length == 0) return [];

        var sortedArr = new SortedSet<int>(arr).ToArray();
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < sortedArr.Length; i++)
        {
            dict[sortedArr[i]] = i + 1;
        }

        var res = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            res[i] = dict[arr[i]];
        }
        return res;
    }
}