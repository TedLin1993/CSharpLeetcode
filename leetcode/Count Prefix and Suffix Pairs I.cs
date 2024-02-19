namespace CSharpLeetcode.leetcode;

public class _3042
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        var n = words.Length;
        var res = 0;
        for (int i = 0; i < n - 1; i++)
        {
            var l1 = words[i].Length;
            for (int j = i + 1; j < n; j++)
            {
                var l2 = words[j].Length;
                if (l1 > l2) continue;
                if (words[j][..l1] == words[i] && words[j][(l2 - l1)..] == words[i])
                {
                    res++;
                }
            }
        }
        return res;
    }
}