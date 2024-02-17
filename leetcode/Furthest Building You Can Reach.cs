namespace CSharpLeetcode.leetcode;

public class _1642
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var pq = new PriorityQueue<int, int>();
        for (int i = 1; i < heights.Length; i++)
        {
            var gap = heights[i] - heights[i - 1];
            if (gap <= 0) continue;
            pq.Enqueue(gap, gap);
            if (pq.Count > ladders)
            {
                bricks -= pq.Dequeue();
            }
            if (bricks < 0) return i - 1;
        }
        return heights.Length - 1;
    }
}