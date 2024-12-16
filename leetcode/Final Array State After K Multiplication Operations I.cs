namespace CSharpLeetcode.leetcode;

public class _3264
{
    record struct Pair(int Idx, int Val);
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var heap = new PriorityQueue<Pair, Pair>(Comparer<Pair>.Create(
            (x, y) => x.Val != y.Val ? x.Val - y.Val : x.Idx - y.Idx)
        );

        for (int i = 0; i < nums.Length; i++)
        {
            var pair = new Pair(i, nums[i]);
            heap.Enqueue(pair, pair);
        }

        while (k-- > 0)
        {
            var pair = heap.Dequeue();
            pair.Val *= multiplier;
            nums[pair.Idx] = pair.Val;
            heap.Enqueue(pair, pair);
        }
        return nums;
    }
}