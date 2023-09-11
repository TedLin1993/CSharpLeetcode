namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx && sy == fy && t == 1)
            {
                return false;
            }
            var xDiff = Math.Abs(fx - sx);
            var yDiff = Math.Abs(fy - sy);
            var minSteps = Math.Min(xDiff, yDiff) + Math.Abs(xDiff - yDiff);
            return minSteps <= t;
        }
    }
}