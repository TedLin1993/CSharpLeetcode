using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class Odd_Even_Linked_List
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null) return null;
        var left = head;
        var right = head.next;
        while (right != null && right.next != null)
        {
            var temp = right.next;
            right.next = temp.next;
            temp.next = left.next;
            left.next = temp;
            left = left.next;
            right = right.next;
        }
        return head;
    }
}