namespace CSharpLeetcode.leetcode;
public class LRUCache
{
    Dictionary<int, LinkedListNode<int>> cache;
    LinkedList<int> list;
    int limit;

    public LRUCache(int capacity)
    {
        cache = new Dictionary<int, LinkedListNode<int>>();
        list = new LinkedList<int>();
        limit = capacity;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key) && cache[key].List != null)
        {
            var node = cache[key];
            list.Remove(node);
            list.AddFirst(node);
            return node.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key) && cache[key].List != null)
        {
            var node = cache[key];
            list.Remove(node);
        }
        var newNode = list.AddFirst(value);
        cache[key] = newNode;
        if (list.Count > limit)
        {
            list.RemoveLast();
        }
    }
}