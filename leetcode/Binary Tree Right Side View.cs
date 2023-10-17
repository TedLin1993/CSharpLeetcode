using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public class Binary_Tree_Right_Side_View
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null) return new List<int>();
            var res = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                res.Add(queue.Last().val);
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return res;
        }
    }
}