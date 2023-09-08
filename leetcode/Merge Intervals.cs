using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            var intervalList = intervals.OrderBy(x => x[0]).ToList();
            var res = new List<List<int>>();
            var cur = new List<int>(intervalList[0]);
            foreach (var interval in intervalList.Skip(1))
            {
                if (interval[0] <= cur[1])
                {
                    cur[1] = Math.Max(cur[1], interval[1]);
                }
                else
                {
                    res.Add(cur);
                    cur = interval.ToList();
                }
            }
            res.Add(cur);
            return res.Select(x => x.ToArray()).ToArray();
        }
    }
}