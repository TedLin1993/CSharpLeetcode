namespace CSharpLeetcode.leetcode;

public class _165
{
    public int CompareVersion(string version1, string version2)
    {
        var v1 = version1.Split(".");
        var v2 = version2.Split(".");
        var max = Math.Max(v1.Length, v2.Length);
        for (int i = 0; i < max; i++)
        {
            var rev1 = i < v1.Length ? GetRevision(v1[i]) : 0;
            var rev2 = i < v2.Length ? GetRevision(v2[i]) : 0;
            if (rev1 > rev2) return 1;
            else if (rev1 < rev2) return -1;
        }
        return 0;
    }

    public int GetRevision(string revision)
    {
        var res = 0;
        foreach (var c in revision)
        {
            res = res * 10 + c - '0';
        }
        return res;
    }
}