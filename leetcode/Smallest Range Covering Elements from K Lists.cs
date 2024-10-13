namespace CSharpLeetcode.leetcode;

public class _632
{
    record Point(int Val, int Row, int Col);
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        var max = -100001;
        var min = -100001;
        var minHeap = new PriorityQueue<Point, int>();
        for (int i = 0; i < nums.Count; i++)
        {
            minHeap.Enqueue(new Point(nums[i][0], i, 0), nums[i][0]);
            max = Math.Max(max, nums[i][0]);
        }

        var curMax = max;
        while (minHeap.Count == nums.Count)
        {
            (var val, var row, var col) = minHeap.Dequeue();
            var curMin = val;
            if (curMax - curMin < max - min)
            {
                max = curMax;
                min = curMin;
            }

            if (col < nums[row].Count - 1)
            {
                var nextVal = nums[row][col + 1];
                minHeap.Enqueue(new Point(nextVal, row, col + 1), nextVal);
                curMax = Math.Max(curMax, nextVal);
            }
        }

        return [min, max];
    }
}