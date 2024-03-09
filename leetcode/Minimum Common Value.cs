namespace CSharpLeetcode.leetcode;

public class _2540
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var idx1 = 0;
        var idx2 = 0;
        while (idx1 < nums1.Length && idx2 < nums2.Length)
        {
            if (nums1[idx1] == nums2[idx2]) return nums1[idx1];
            if (nums1[idx1] < nums2[idx2]) idx1++;
            else idx2++;
        }
        return -1;
    }
}