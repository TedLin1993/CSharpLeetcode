using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var res = new List<ListNode>();
            var node = head;
            var count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            var avg = count / k;
            var curK = k;
            node = head;
            while (count > 0)
            {
                res.Add(node);
                var length = avg;
                if (count % curK > 0)
                {
                    length++;
                }
                var temp = node;
                for (var i = 0; i < length - 1; i++)
                {
                    temp = temp.next;
                }
                if (temp != null)
                {
                    node = temp.next;
                    temp.next = null;
                }
                curK--;
                count -= length;
            }
            while (res.Count < k)
            {
                res.Add(null);
            }
            return res.ToArray();
        }
    }
}