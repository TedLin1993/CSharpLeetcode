using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _513
{
    public int FindBottomLeftValue(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var res = root.val;
        while (queue.Count > 0)
        {
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (queue.Count > 0) res = queue.Peek().val;
        }
        return res;
    }
}