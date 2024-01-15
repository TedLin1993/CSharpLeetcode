namespace CSharpLeetcode.leetcode;

public class _3006
{
    public IList<int> BeautifulIndices(string s, string a, string b, int k)
    {
        var sLen = s.Length;
        var aLen = a.Length;
        var bLen = b.Length;
        List<int> iList = [];
        List<int> jList = [];
        for (int i = 0; i < sLen; i++)
        {
            if (i + aLen - 1 < sLen && s[i..(i + aLen)] == a)
            {
                iList.Add(i);
            }
            if (i + bLen - 1 < sLen && s[i..(i + bLen)] == b)
            {
                jList.Add(i);
            }
        }
        var jIdx = 0;
        List<int> res = [];
        foreach (var i in iList)
        {
            while (jIdx < jList.Count)
            {
                if (Math.Abs(i - jList[jIdx]) <= k)
                {
                    res.Add(i);
                    break;
                }
                if (jList[jIdx] - i > k)
                {
                    break;
                }
                jIdx++;
            }
        }
        return res;
    }
}