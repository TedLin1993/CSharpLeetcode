namespace CSharpLeetcode.leetcode;
public class Rotate_Array
{
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;
        k %= n;
        var res = new int[n];
        for (int i = 0; i < k; i++)
        {
            res[i] = nums[n - k + i];
        }
        for (int i = k; i < n; i++)
        {
            res[i] = nums[i - k];
        }
        for (int i = 0; i < n; i++)
        {
            nums[i] = res[i];
        }
    }
}