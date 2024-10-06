namespace CSharpLeetcode.leetcode;

public class _1813
{
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        if (sentence1.Length <= sentence2.Length)
            return IsSimilar(sentence1, sentence2);
        return IsSimilar(sentence2, sentence1);

    }

    public bool IsSimilar(string small, string big)
    {
        var s1 = small.Split(' ').ToList();
        var s2 = big.Split(' ').ToList();

        var leftCount = 0;
        for (int i = 0; i < s1.Count; i++)
        {
            if (s1[i] == s2[i])
            {
                leftCount++;
            }
            else
            {
                break;
            }
        }
        if (leftCount == s1.Count) return true;

        var rightCount = 0;
        for (int i = 0; i < s1.Count; i++)
        {
            var s1Idx = s1.Count - 1 - i;
            var s2Idx = s2.Count - 1 - i;
            if (s1[s1Idx] == s2[s2Idx])
            {
                rightCount++;
            }
            else
            {
                break;
            }
        }
        if (rightCount == s1.Count) return true;

        return leftCount + rightCount >= s1.Count;
    }
}