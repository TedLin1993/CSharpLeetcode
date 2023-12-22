namespace CSharpLeetcode.leetcode;

public class _528
{
    Random r;
    List<int> preSum;
    int sum;
    public _528(int[] w)
    {
        r = new Random();
        preSum = [0];
        sum = 0;
        for (int i = 0; i < w.Length; i++)
        {
            sum += w[i];
            preSum.Add(sum);
        }
    }

    public int PickIndex()
    {
        var weight = r.Next(sum);
        var left = 0;
        var right = preSum.Count - 2;
        while (left < right)
        {
            var mid = left + (right - left + 1) / 2;
            if (preSum[mid] == weight)
            {
                return mid;
            }
            else if (preSum[mid] > weight)
            {
                right = mid - 1;
            }
            else
            {
                left = mid;
            }
        }
        return left;
    }
    public static void Test()
    {
        var test = new _528([1, 3]);
        Console.WriteLine(test.PickIndex());
        Console.WriteLine(test.PickIndex());
        Console.WriteLine(test.PickIndex());
        Console.WriteLine(test.PickIndex());
    }
}