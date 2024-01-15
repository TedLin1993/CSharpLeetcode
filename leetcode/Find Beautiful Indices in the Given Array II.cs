using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _3008
{
    public IList<int> BeautifulIndices(string s, string a, string b, int k)
    {
        var iList = Model.KMPSearch(s, a);
        var jList = Model.KMPSearch(s, b);
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