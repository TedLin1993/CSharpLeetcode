namespace CSharpLeetcode.leetcode;

public class FindSumPairs
{
    int[] Nums1;
    int[] Nums2;
    Dictionary<int, int> Dict;

    public FindSumPairs(int[] nums1, int[] nums2)
    {
        Nums1 = nums1;
        Nums2 = nums2;
        Dict = [];
        foreach (var v in nums2)
        {
            Dict[v] = Dict.GetValueOrDefault(v) + 1;
        }
    }

    public void Add(int index, int val)
    {
        Dict[Nums2[index]]--;
        Nums2[index] += val;
        Dict[Nums2[index]] = Dict.GetValueOrDefault(Nums2[index]) + 1;
    }

    public int Count(int tot)
    {
        var res = 0;
        foreach (var v in Nums1)
        {
            res += Dict.GetValueOrDefault(tot - v);
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