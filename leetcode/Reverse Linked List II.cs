using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            var preLeft = new ListNode { next = head };
            var node = preLeft;
            for (int i = 0; i < left - 1; i++) node = node.next;
            preLeft = node;
            node = node.next;

            for (int i = 0; i < right - left; i++)
            {
                var next = node.next;
                node.next = next.next;
                next.next = preLeft.next;
                preLeft.next = next;
            }
            if (left == 1) return preLeft.next;
            return head;
        }
    }
}
