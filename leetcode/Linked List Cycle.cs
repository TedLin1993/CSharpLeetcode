using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _141
{
    public bool HasCycle(ListNode head)
    {
        var left = head;
        var right = head;
        while (right != null && right.next != null)
        {
            left = left.next;
            right = right.next.next;
            if (left == right) return true;
        }
        return false;
    }
}