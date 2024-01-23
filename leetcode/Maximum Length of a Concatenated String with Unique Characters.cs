namespace CSharpLeetcode.leetcode;

public class _1239
{
    public int MaxLength(IList<string> arr)
    {
        var res = 0;
        void dfs(int idx, bool[] cache, int curLen)
        {
            var a = arr[idx];
            for (int i = 0; i < a.Length; i++)
            {
                if (cache[a[i] - 'a']) return;
                cache[a[i] - 'a'] = true;
            }
            curLen += a.Length;
            res = Math.Max(res, curLen);
            for (int i = idx + 1; i < arr.Count; i++)
            {
                var cloneCache = (bool[])cache.Clone();
                dfs(i, cloneCache, curLen);
            }
        }
        for (int i = 0; i < arr.Count; i++)
        {
            dfs(i, new bool[26], 0);
        }
        return res;
    }
}