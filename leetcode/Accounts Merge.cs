namespace CSharpLeetcode.leetcode
{
    public class Accounts_Merge
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var emailIdxDict = new Dictionary<string, HashSet<int>>();
            for (int i = 0; i < accounts.Count; i++)
            {
                for (int j = 1; j < accounts[i].Count; j++)
                {
                    var email = accounts[i][j];
                    if (!emailIdxDict.ContainsKey(accounts[i][j])) emailIdxDict.Add(email, new HashSet<int> { i });
                    else emailIdxDict[email].Add(i);
                }
            }

            var visited = new HashSet<string>();
            List<string> dfs(string email)
            {
                if (visited.Contains(email)) return new List<string>();
                var res = new List<string> { email };
                visited.Add(email);
                foreach (var i in emailIdxDict[email])
                {
                    for (int j = 1; j < accounts[i].Count; j++)
                    {
                        res.AddRange(dfs(accounts[i][j]));
                    }
                }
                return res;
            }

            var res = new List<IList<string>>();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (!visited.Contains(accounts[i][1]))
                {
                    var list = dfs(accounts[i][1]);
                    list.Sort(StringComparer.Ordinal);
                    list.Insert(0, accounts[i][0]);
                    res.Add(list);
                }
            }
            return res;
        }
        public void Test()
        {
            List<IList<string>> test =
            [
                ["John", "johnsmith@mail.com", "john_newyork@mail.com"],
                ["John", "johnsmith@mail.com", "john00@mail.com"],
                ["Mary", "mary@mail.com"],
                ["John", "johnnybravo@mail.com"]
            ];
            Console.WriteLine(AccountsMerge(test));
        }
    }
}