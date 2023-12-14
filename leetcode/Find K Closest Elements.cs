namespace CSharpLeetcode.leetcode;

public class Find_K_Closest_Elements
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var left = 0;
        var right = arr.Length - k;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (x - arr[mid] > arr[mid + k] - x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return arr[left..(left + k)].ToList();
    }
}