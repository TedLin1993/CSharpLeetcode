namespace CSharpLeetcode.leetcode;

public class FindSumPairs
{
    int[] Nums2;
    Dictionary<int, int> Dict1;
    Dictionary<int, int> Dict2;

    public FindSumPairs(int[] nums1, int[] nums2)
    {
        Nums2 = nums2;
        Dict1 = [];
        Dict2 = [];
        foreach (var v in nums1)
        {
            Dict1[v] = Dict1.GetValueOrDefault(v) + 1;
        }
        foreach (var v in nums2)
        {
            Dict2[v] = Dict2.GetValueOrDefault(v) + 1;
        }
    }

    public void Add(int index, int val)
    {
        Dict2[Nums2[index]]--;
        Nums2[index] += val;
        Dict2[Nums2[index]] = Dict2.GetValueOrDefault(Nums2[index]) + 1;
    }

    public int Count(int tot)
    {
        var res = 0;
        foreach (var kvp in Dict1)
        {
            res += kvp.Value * Dict2.GetValueOrDefault(tot - kvp.Key);
        }
        return res;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */