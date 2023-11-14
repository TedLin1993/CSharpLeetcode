namespace CSharpLeetcode.leetcode;
public class Group_Anagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anaGroup = new Dictionary<string, int>();
        var res = new List<IList<string>>();
        foreach (var str in strs)
        {
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var sortedStr = new string(charArr);
            if (anaGroup.ContainsKey(sortedStr))
            {
                res[anaGroup[sortedStr]].Add(str);
            }
            else
            {
                res.Add(new List<string> { str });
                anaGroup.Add(sortedStr, res.Count - 1);
            }
        }
        return res;
    }
    public void Test()
    {
        GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
    }
}