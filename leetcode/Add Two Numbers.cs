using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class _2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var isCarry = false;
        var dummy = new ListNode();
        var node = dummy;
        while (l1 != null || l2 != null)
        {
            var val = isCarry ? 1 : 0;
            if (l1 != null)
            {
                val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                val += l2.val;
                l2 = l2.next;
            }
            node.next = new ListNode(val % 10);
            node = node.next;
            isCarry = val / 10 == 1;
        }
        if (isCarry)
        {
            node.next = new ListNode(1);
        }
        return dummy.next;
    }
}