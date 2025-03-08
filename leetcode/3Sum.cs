namespace CSharpLeetcode.leetcode;

public class _15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        var res = new List<IList<int>>();
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            var target = -nums[i];
            var left = i + 1;
            var right = n - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else
                {
                    if (left == i + 1 || nums[left] != nums[left - 1] || right == n - 1 || nums[right] != nums[right + 1])
                    {
                        res.Add([nums[i], nums[left], nums[right]]);
                    }
                    left++;
                    right--;
                }
            }
        }
        return res;
    }
}