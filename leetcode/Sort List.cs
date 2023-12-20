using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class _148
{
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        var slow = head;
        var fast = head.next;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        var head2 = slow.next;
        slow.next = null;
        head = SortList(head);
        head2 = SortList(head2);
        return Merge(head, head2);
    }
    ListNode Merge(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var node = dummy;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                node.next = l1;
                l1 = l1.next;
            }
            else
            {
                node.next = l2;
                l2 = l2.next;
            }
            node = node.next;
        }
        if (l1 != null)
        {
            node.next = l1;
        }
        if (l2 != null)
        {
            node.next = l2;
        }
        return dummy.next;
    }
}