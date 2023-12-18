namespace CSharpLeetcode.leetcode;
public class Divide_Array_Into_Arrays_With_Max_Difference
{
    public int[][] DivideArray(int[] nums, int k)
    {
        var n = nums.Length;
        Array.Sort(nums);
        var res = new List<int[]>();
        for (int i = 0; i + 2 < n; i += 3)
        {
            if (nums[i + 2] - nums[i] > k) return [];
            res.Add(nums[i..(i + 3)]);
        }
        return res.ToArray();
    }
}