using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var n = nums.Length;
            var visited = new bool[n];
            var res = new List<IList<int>>();
            void dfs(List<int> current)
            {
                if (current.Count == n)
                {
                    var temp = new List<int>(current);
                    res.Add(temp);
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        dfs(current.Append(nums[i]).ToList());
                        visited[i] = false;
                    }
                }
            }
            dfs(new List<int>());
            return res;
        }
    }
}