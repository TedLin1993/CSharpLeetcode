namespace CSharpLeetcode.leetcode;
public class High_Access_Employees
{
    public IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
    {
        var dict = new Dictionary<string, List<int>>();
        foreach (var a in access_times)
        {
            var key = a[0];
            var time = Convert.ToInt32(a[1]);
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new List<int>());
            }
            dict[key].Add(time);
        }
        var res = new List<string>();
        foreach (var kvp in dict)
        {
            kvp.Value.Sort();
            for (int i = 2; i < kvp.Value.Count; i++)
            {
                if (kvp.Value[i] - kvp.Value[i - 2] < 100)
                {
                    res.Add(kvp.Key);
                    break;
                }
            }
        }
        return res;
    }
    public void Test()
    {
        var test = new List<IList<string>>
        {
            new List<string> { "a", "0549" },
            new List<string> { "b", "0457" },
            new List<string> { "a", "0532" },
            new List<string> { "a", "0621" },
            new List<string> { "b", "0540" }
        };
        FindHighAccessEmployees(test);
    }
}