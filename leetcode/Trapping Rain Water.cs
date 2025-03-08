public class _42
{
    // TC: O(n)
    // SC: O(1)
    public int Trap(int[] height)
    {
        var n = height.Length;
        var preMax = 0;
        var sufMax = 0;
        var left = 0;
        var right = n - 1;
        var res = 0;
        while (left <= right)
        {
            preMax = Math.Max(preMax, height[left]);
            sufMax = Math.Max(sufMax, height[right]);
            if (preMax < sufMax)
            {
                res += preMax - height[left];
                left++;
            }
            else
            {
                res += sufMax - height[right];
                right--;
            }
        }
        return res;
    }
}