namespace CSharpLeetcode.leetcode;

public class Find_K_Closest_Elements
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        if (x < arr[0]) return arr[..k].ToList();
        var left = 0;
        var right = k;
        while (right < arr.Length && arr[right] < x)
        {
            right++;
            left++;
        }
        while (right < arr.Length)
        {
            if (arr[right] - x >= x - arr[left]) break;
            right++;
            left++;
        }
        return arr[left..right].ToList();
    }
}