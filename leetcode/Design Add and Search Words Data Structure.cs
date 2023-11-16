namespace CSharpLeetcode.leetcode;
public class Trie
{
    public Trie[] Next;
    public bool IsEnd;
    public Trie()
    {
        Next = new Trie[26];
    }
}
public class WordDictionary
{
    Trie trie;

    public WordDictionary()
    {
        trie = new Trie();
    }

    public void AddWord(string word)
    {
        var cur = trie;
        var n = word.Length;
        for (int i = 0; i < n; i++)
        {
            if (cur.Next[word[i] - 'a'] == null)
            {
                cur.Next[word[i] - 'a'] = new Trie
                {
                    Next = new Trie[26]
                };
            }
            cur = cur.Next[word[i] - 'a'];
            if (i == n - 1) cur.IsEnd = true;
        }
    }

    public bool Search(string word)
    {
        return Search(word, 0, trie);
    }

    public bool Search(string word, int index, Trie cur)
    {
        if (cur == null) return false;
        if (index == word.Length) return cur.IsEnd;
        if (word[index] == '.')
        {
            for (int i = 0; i < 26; i++)
            {
                if (Search(word, index + 1, cur.Next[i]))
                {
                    return true;
                }
            }
            return false;
        }
        return Search(word, index + 1, cur.Next[word[index] - 'a']);
    }
}