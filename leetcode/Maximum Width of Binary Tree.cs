using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class Maximum_Width_of_Binary_Tree
{
    record Pair(TreeNode node, int label);
    public int WidthOfBinaryTree(TreeNode root)
    {
        var queue = new Queue<Pair>();
        queue.Enqueue(new Pair(root, 0));
        var res = 1;
        while (queue.Count > 0)
        {
            res = Math.Max(res, queue.Last().label - queue.First().label + 1);
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var p = queue.Dequeue();
                if (p.node.left != null)
                {
                    queue.Enqueue(new Pair(p.node.left, 2 * p.label));
                }
                if (p.node.right != null)
                {
                    queue.Enqueue(new Pair(p.node.right, 2 * p.label + 1));
                }
            }
        }
        return res;
    }
}