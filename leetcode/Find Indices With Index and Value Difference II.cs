namespace CSharpLeetcode.leetcode
{
    public class Find_Indices_With_Index_and_Value_Difference_II
    {
        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            var n = nums.Length;
            var minIdx = 0;
            var maxIdx = 0;
            for (int i = indexDifference; i < n; i++)
            {
                if (nums[i - indexDifference] < nums[minIdx]) minIdx = i - indexDifference;
                if (nums[i - indexDifference] > nums[maxIdx]) maxIdx = i - indexDifference;
                if (nums[i] - nums[minIdx] >= valueDifference) return new int[] { minIdx, i };
                if (nums[maxIdx] - nums[i] >= valueDifference) return new int[] { maxIdx, i };
            }
            return new int[] { -1, -1 };
        }
    }
}