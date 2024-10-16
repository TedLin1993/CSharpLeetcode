using System.Text;

namespace CSharpLeetcode.leetcode;

public class _1405
{
    public string LongestDiverseString(int a, int b, int c)
    {
        var maxHeap = new PriorityQueue<Pair, int>(Comparer<int>.Create((x, y) => y - x));
        if (a > 0) maxHeap.Enqueue(new Pair(a, 'a'), a);
        if (b > 0) maxHeap.Enqueue(new Pair(b, 'b'), b);
        if (c > 0) maxHeap.Enqueue(new Pair(c, 'c'), c);

        var res = new StringBuilder();
        while (maxHeap.Count > 0)
        {
            var pair = maxHeap.Dequeue();
            if (res.Length >= 2 && res[^1] == res[^2] && res[^2] == pair.Char)
            {
                if (maxHeap.Count == 0) return res.ToString();
                var pair2 = maxHeap.Dequeue();
                res.Append(pair2.Char);
                pair2.Count--;
                if (pair2.Count > 0) maxHeap.Enqueue(pair2, pair2.Count);
                maxHeap.Enqueue(pair, pair.Count);
            }
            else
            {
                res.Append(pair.Char);
                pair.Count--;
                if (pair.Count > 0) maxHeap.Enqueue(pair, pair.Count);
            }
        }
        return res.ToString();
    }

    public class Pair(int Count, char Char)
    {
        public int Count { get; set; } = Count;
        public char Char { get; set; } = Char;
    }
}