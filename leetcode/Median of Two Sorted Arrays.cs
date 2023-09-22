namespace CSharpLeetcode.leetcode
{
    public class Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                (nums1, nums2) = (nums2, nums1);
            }
            var m = nums1.Length;
            var n = nums2.Length;
            var left = 0;
            var right = m;
            while (left <= right)
            {
                var mIdx = left + (right - left) / 2;
                var nIdx = (m + n + 1) / 2 - mIdx;

                var mLeft = mIdx == 0 ? int.MinValue : nums1[mIdx - 1];
                var mRight = mIdx == m ? int.MaxValue : nums1[mIdx];

                var nLeft = nIdx == 0 ? int.MinValue : nums2[nIdx - 1];
                var nRight = nIdx == n ? int.MaxValue : nums2[nIdx];
                if (mLeft <= nRight && nLeft <= mRight)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (double)(Math.Max(mLeft, nLeft) + Math.Min(mRight, nRight)) / 2;
                    }
                    else
                    {
                        return Math.Max(mLeft, nLeft);
                    }
                }
                else if (mLeft > nRight)
                {
                    right = mIdx - 1;
                }
                else
                {
                    left = mIdx + 1;
                }
            }
            return -1;
        }

        public void Test()
        {
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 })); //2
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 })); //2.5
        }
    }
}