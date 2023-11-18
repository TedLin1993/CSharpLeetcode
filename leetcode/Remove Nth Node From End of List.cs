using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class Remove_Nth_Node_From_End_of_List
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var left = dummy;
        var right = dummy;
        for (int i = 0; i < n; i++)
        {
            right = right.next;
        }
        while (right.next != null)
        {
            left = left.next;
            right = right.next;
        }
        left.next = left.next.next;
        return dummy.next;
    }
}