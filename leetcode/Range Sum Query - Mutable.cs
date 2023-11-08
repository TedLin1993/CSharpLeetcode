namespace CSharpLeetcode.leetcode;
public class RangeSumQuert
{
    public class NumArray
    {
        int[] bit;
        int[] nums;
        public NumArray(int[] nums)
        {
            bit = new int[nums.Length + 1];
            this.nums = nums;
            for (int i = 0; i < nums.Length; i++)
            {
                Update(i, nums[i]);
            }
        }

        public void Update(int index, int val)
        {
            var diff = val - nums[index];
            nums[index] = val;
            UpdateBit(index, diff);
        }

        void UpdateBit(int index, int val)
        {
            index++;
            while (index < bit.Length)
            {
                bit[index] += val;
                index += index & -index;
            }
        }

        public int SumRange(int left, int right)
        {
            var sumLeft = 0;
            while (left > 0)
            {
                sumLeft += bit[left];
                left -= left & -left;
            }
            var sumRight = 0;
            right++;
            while (right > 0)
            {
                sumRight += bit[right];
                right -= right & -right;
            }
            return sumRight - sumLeft;
        }
    }
    public void Test()
    {
        var obj = new NumArray(new int[] { 1, 3, 5 });
    }
}


/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */