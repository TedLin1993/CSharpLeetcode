namespace CSharpLeetcode.leetcode;

public class _3043
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        HashSet<int> set = [];
        foreach (var v in arr1)
        {
            var num = v;
            while (num > 0)
            {
                set.Add(num);
                num /= 10;
            }
        }
        var res = 0;
        foreach (var v in arr2)
        {
            var num = v;
            var temp = 0;
            while (num > 0)
            {
                if (set.Contains(num))
                {
                    temp = (int)Math.Log10(num) + 1;
                    break;
                }
                num /= 10;
            }
            res = Math.Max(res, temp);
        }
        return res;
    }
    public void Test()
    {
        Console.WriteLine(LongestCommonPrefix([1, 10, 100], [1000])); //3
    }
}