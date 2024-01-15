namespace CSharpLeetcode.model;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x)
    {
        val = x;
    }
}
public class Model
{
    public static List<int> KMPSearch(string text, string pattern)
    {
        int N = text.Length;
        int M = pattern.Length;
        List<int> matchedIndex = new List<int>();
        if (N < M) return matchedIndex;
        if (N == M && text == pattern)
        {
            matchedIndex.Add(0);
            return matchedIndex;
        }

        int[] lpsArray = new int[M];
        LongestPrefixSuffix(pattern, ref lpsArray);

        int i = 0, j = 0;
        while (i < N)
        {
            if (text[i] == pattern[j])
            {
                i++;
                j++;
            }

            if (j == M)
            {
                matchedIndex.Add(i - j);
                j = lpsArray[j - 1];
            }
            else if (i < N && text[i] != pattern[j])
            {
                if (j != 0)
                {
                    j = lpsArray[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return matchedIndex;
    }

    static void LongestPrefixSuffix(string pattern, ref int[] lpsArray)
    {
        int M = pattern.Length;
        int len = 0;
        lpsArray[0] = 0;
        int i = 1;

        while (i < M)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lpsArray[i] = len;
                i++;
            }
            else
            {
                if (len == 0)
                {
                    lpsArray[i] = 0;
                    i++;
                }
                else
                {
                    len = lpsArray[len - 1];
                }
            }
        }
    }
}