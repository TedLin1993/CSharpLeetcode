namespace CSharpLeetcode.leetcode;
public class RandomizedSet
{
    Dictionary<int, int> dict;
    List<int> list;
    Random rnd;
    public RandomizedSet()
    {
        dict = [];
        list = [];
        rnd = new Random();
    }

    public bool Insert(int val)
    {
        if (dict.ContainsKey(val)) return false;
        dict.Add(val, list.Count);
        list.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!dict.ContainsKey(val)) return false;
        var idx = dict[val];
        (list[idx], list[list.Count - 1]) = (list[list.Count - 1], list[idx]);
        dict[list[idx]] = idx;
        dict.Remove(val);
        list = list[..(list.Count - 1)];
        return true;
    }

    public int GetRandom()
    {
        return list[rnd.Next(list.Count)];
    }
}