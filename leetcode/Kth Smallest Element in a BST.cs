using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class Kth_Smallest_Element_in_a_BST
{
    public int KthSmallest_pq(TreeNode root, int k)
    {
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (maxHeap.Count < k || node.val < maxHeap.Peek())
            {
                maxHeap.Enqueue(node.val, node.val);
                if (maxHeap.Count > k) maxHeap.Dequeue();
            }
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }
        return maxHeap.Peek();
    }

    public int KthSmallest(TreeNode root, int k)
    {
        var res = -1;
        void dfs(TreeNode node)
        {
            if (node == null || k <= 0) return;
            dfs(node.left);
            k--;
            if (k == 0) res = node.val;
            dfs(node.right);
        }
        dfs(root);
        return res;
    }
}