namespace CSharpLeetcode.leetcode
{
    public class Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            var n = height.Length;
            var left = 0;
            var right = n - 1;
            var res = 0;
            while (left < right)
            {
                var cur = Math.Min(height[left], height[right]) * (right - left);
                res = Math.Max(res, cur);
                if (height[left] <= height[right]) left++;
                else right--;
            }
            return res;
        }
    }
}