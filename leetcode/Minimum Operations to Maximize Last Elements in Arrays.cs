namespace CSharpLeetcode.leetcode;
public class Minimum_Operations_to_Maximize_Last_Elements_in_Arrays
{
    public int MinOperations(int[] nums1, int[] nums2)
    {
        var n = nums1.Length;
        int count(int last1, int last2)
        {
            var res = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (nums1[i] > last1 || nums2[i] > last2)
                {
                    if (nums1[i] > last2 || nums2[i] > last1)
                    {
                        return n + 1;
                    }
                    res++;
                }
            }
            return res;
        }
        var res = Math.Min(count(nums1.Last(), nums2.Last()), 1 + count(nums2.Last(), nums1.Last()));
        return res <= n ? res : -1;
    }
}