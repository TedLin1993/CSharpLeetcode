namespace CSharpLeetcode.leetcode
{
    /**
    * This is MountainArray's API interface.
    * You should not implement it, or speculate about its implementation
    * class MountainArray {
    *     public int Get(int index) {}
    *     public int Length() {}
    * }
    */

    // only for testing purposes
    class MountainArray
    {
        public int Get(int index) { return 0; }
        public int Length() { return 0; }
    }

    class Find_in_Mountain_Array
    {
        public int FindInMountainArray(int target, MountainArray mountainArr)
        {
            var n = mountainArr.Length();
            var left = 0;
            var right = n - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            var peak = left;
            left = 0;
            right = peak;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var midVal = mountainArr.Get(mid);
                if (midVal < target)
                {
                    left = mid + 1;
                }
                else if (midVal > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            left = peak;
            right = n - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var midVal = mountainArr.Get(mid);
                if (midVal < target)
                {
                    right = mid - 1;
                }
                else if (midVal > target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}