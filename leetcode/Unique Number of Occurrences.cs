namespace CSharpLeetcode.leetcode;

public class _1207
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = [];
        foreach (var v in arr)
        {
            dict[v] = dict.GetValueOrDefault(v) + 1;
        }
        HashSet<int> set = [];
        foreach (var kvp in dict)
        {
            if (set.Contains(kvp.Value)) return false;
            set.Add(kvp.Value);
        }
        return true;
    }
}