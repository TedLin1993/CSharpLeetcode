using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public long PickGifts(int[] gifts, int k)
        {
            var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            foreach (var gift in gifts)
            {
                maxHeap.Enqueue(gift, gift);
            }
            for (int i = 0; i < k; i++)
            {
                var gift = maxHeap.Dequeue();
                var giftD = Math.Sqrt(Convert.ToDouble(gift));
                gift = Convert.ToInt32(Math.Floor(giftD));
                maxHeap.Enqueue(gift, gift);
            }

            var sum = 0;
            while (maxHeap.Count > 0)
            {
                sum += maxHeap.Dequeue();
            }
            return sum;
        }
    }
}