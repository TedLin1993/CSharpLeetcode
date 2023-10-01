namespace CSharpLeetcode.leetcode
{
    public class Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            var n = nums.Length;
            var left = 0;
            var right = n - 1;
            var idx = 0;
            while (idx <= right)
            {
                if (nums[idx] == 0)
                {
                    (nums[left], nums[idx]) = (nums[idx], nums[left]);
                    if (idx == left) idx++;
                    left++;

                }
                else if (nums[idx] == 2)
                {
                    (nums[right], nums[idx]) = (nums[idx], nums[right]);
                    right--;
                }
                else idx++;
            }
        }
    }
}