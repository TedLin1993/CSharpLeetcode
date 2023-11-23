namespace CSharpLeetcode.leetcode;
public class Longest_Increasing_Subsequence
{
    public int LengthOfLIS(int[] nums)
    {
        var res = new List<int> { nums[0] };
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > res.Last())
            {
                res.Add(nums[i]);
            }
            else
            {
                var index = binarySearch(res, nums[i]);
                res[index] = nums[i];
            }
        }
        return res.Count;
    }
    int binarySearch(List<int> list, int val)
    {
        var n = list.Count;
        var left = 0;
        var right = n - 1;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (list[mid] < val)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
    public void Test()
    {
        var test = LengthOfLIS([10, 9, 2, 5, 3, 4]);
        Console.WriteLine(test); //3
    }
}