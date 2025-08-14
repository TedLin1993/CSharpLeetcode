namespace CSharpLeetcode.leetcode;

public class _2264
{
    public string LargestGoodInteger(string num)
    {
        var res = "";
        for (int i = 0; i <= num.Length - 3; i++)
        {
            var v = num[i];
            if (v == num[i + 1] && v == num[i + 2] && (res == "" || (res != "" && v > res[0])))
            {
                res = num[i..(i + 3)];
            }
        }
        return res;
    }
}