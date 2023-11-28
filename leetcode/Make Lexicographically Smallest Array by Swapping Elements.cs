namespace CSharpLeetcode.leetcode;

public class Make_Lexicographically_Smallest_Array_by_Swapping_Elements
{
    record Pair(int idx, int num);
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        var n = nums.Length;
        var pairList = new List<Pair>();
        for (int i = 0; i < n; i++)
        {
            pairList.Add(new Pair(i, nums[i]));
        }
        pairList.Sort((a, b) => a.num - b.num);

        var res = new int[n];
        var left = 0;
        while (left < n)
        {
            var right = left;
            for (int i = left + 1; i < n; i++)
            {
                if (pairList[i].num - pairList[i - 1].num <= limit)
                {
                    right = i;
                }
                else
                {
                    break;
                }
            }
            var idxes = pairList.Skip(left).Take(right - left + 1)
                .Select(x => x.idx).OrderBy(x => x).ToList();
            for (int i = 0; i < idxes.Count; i++)
            {
                res[idxes[i]] = pairList[left + i].num;
            }
            left = right + 1;
        }
        return res;
    }
}