namespace CSharpLeetcode.leetcode
{
    public class Subsets_
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>
            {
                new List<int>()
            };
            var cur = new List<int>();
            void dfs(int idx)
            {
                if (idx == nums.Length) return;
                cur.Add(nums[idx]);
                res.Add(new List<int>(cur));
                dfs(idx + 1);
                cur.RemoveAt(cur.Count - 1);
                dfs(idx + 1);
            }
            dfs(0);
            return res;
        }
    }
}