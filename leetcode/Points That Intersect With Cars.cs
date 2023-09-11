namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int NumberOfPoints(IList<IList<int>> nums)
        {
            nums = nums.OrderBy(x => x[0]).ToList();
            var res = 0;
            var cur = nums[0];
            foreach (var num in nums.Skip(1))
            {
                if (num[0] <= cur[1])
                {
                    cur[1] = Math.Max(cur[1], num[1]);
                }
                else
                {
                    res += cur[1] - cur[0] + 1;
                    cur = num;
                }
            }
            res += cur[1] - cur[0] + 1;
            return res;
        }
    }
}
