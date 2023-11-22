namespace CSharpLeetcode.leetcode;
public class Top_K_Frequent_Words
{
    record Pair(int count, string word);
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!dict.ContainsKey(word)) dict.Add(word, 0);
            dict[word]++;
        }
        var minHeap = new PriorityQueue<int, Pair>(Comparer<Pair>.Create((x, y) =>
        {
            if (x.count != y.count) return x.count - y.count;
            return string.Compare(y.word, x.word);
        }));
        foreach (var kvp in dict)
        {
            if (minHeap.Count < k) minHeap.Enqueue(kvp.Value, new Pair(kvp.Value, kvp.Key));
            else if (kvp.Value >= minHeap.Peek()) minHeap.EnqueueDequeue(kvp.Value, new Pair(kvp.Value, kvp.Key));
        }
        var res = new List<string>();
        while (minHeap.Count > 0)
        {
            minHeap.TryDequeue(out _, out var pair);
            res.Add(pair.word);
        }
        res.Reverse();
        return res;
    }
}