namespace CSharpLeetcode.leetcode;
public class _3045
{
    public record Pair(char pre, char suf);
    public class Trie
    {
        public Dictionary<Pair, Trie> Next;
        public int Count;
        public Trie()
        {
            Next = [];
        }
    }
    public long CountPrefixSuffixPairs(string[] words)
    {
        long res = 0;
        var root = new Trie();
        foreach (var w in words)
        {
            var cur = root;
            for (int i = 0; i < w.Length; i++)
            {
                var pair = new Pair(w[i], w[w.Length - 1 - i]);
                if (!cur.Next.ContainsKey(pair)) cur.Next[pair] = new Trie();
                cur = cur.Next[pair];
                res += cur.Count;
            }
            cur.Count++;
        }
        return res;
    }
}