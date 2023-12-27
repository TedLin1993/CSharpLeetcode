using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class _103
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var isFromLeft = true;
        while (queue.Count > 0)
        {
            var count = queue.Count;
            var temp = new List<int>();
            for (int i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                temp.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (!isFromLeft) temp.Reverse();
            res.Add(temp);
            isFromLeft = !isFromLeft;
        }
        return res;
    }
}