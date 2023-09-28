namespace CSharpLeetcode.leetcode
{
    public class Sort_Array_By_Parity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var evenIdx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    (nums[evenIdx], nums[i]) = (nums[i], nums[evenIdx]);
                    evenIdx++;
                }
            }
            return nums;
        }
    }
}