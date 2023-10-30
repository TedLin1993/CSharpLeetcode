namespace CSharpLeetcode.leetcode
{
    public class Minimum_Equal_Sum_of_Two_Arrays_After_Replacing_Zeros
    {
        public long MinSum(int[] nums1, int[] nums2)
        {
            long min1 = 0;
            var zero1 = 0;
            foreach (var num in nums1)
            {
                if (num != 0)
                {
                    min1 += num;
                }
                else
                {
                    zero1++;
                    min1 += 1;
                }
            }
            long min2 = 0;
            var zero2 = 0;
            foreach (var num in nums2)
            {
                if (num != 0)
                {
                    min2 += num;
                }
                else
                {
                    zero2++;
                    min2 += 1;
                }
            }

            if (zero1 == 0 && min2 > min1) return -1;
            if (zero2 == 0 && min1 > min2) return -1;
            return Math.Max(min1, min2);
        }
    }
}