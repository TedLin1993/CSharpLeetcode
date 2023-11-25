using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class Swap_Nodes_in_Pairs
{
    public ListNode SwapPairs(ListNode head)
    {
        var dummy = new ListNode(0, head);
        var node = dummy;
        while (node.next != null && node.next.next != null)
        {
            var temp = node.next;
            node.next = temp.next;
            temp.next = temp.next.next;
            node.next.next = temp;
            node = node.next.next;
        }
        return dummy.next;
    }
}