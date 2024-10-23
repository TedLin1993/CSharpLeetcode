using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _2641
{
    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        root.val = 0;
        var queue = new Queue<TreeNode>([root]);
        while (queue.Count > 0)
        {
            var sum = 0;
            foreach (var node in queue)
            {
                if (node.left != null) sum += node.left.val;
                if (node.right != null) sum += node.right.val;
            }

            var len = queue.Count;
            for (int i = 0; i < len; i++)
            {
                var node = queue.Dequeue();
                var nodeSum = 0;
                if (node.left != null) nodeSum += node.left.val;
                if (node.right != null) nodeSum += node.right.val;
                if (node.left != null)
                {
                    node.left.val = sum - nodeSum;
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    node.right.val = sum - nodeSum;
                    queue.Enqueue(node.right);
                }
            }
        }
        return root;
    }
}