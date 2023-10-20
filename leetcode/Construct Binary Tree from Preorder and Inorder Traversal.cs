using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public class ConstructBinaryTreefromPreorderAndInorderTraversal
    {
        // preorder: cur -> left -> right
        // inorder: let -> cur -> right
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0) return null;
            var cur = new TreeNode(preorder[0]);
            var curIdx = Array.IndexOf(inorder, cur.val);
            cur.left = BuildTree(preorder[1..(curIdx + 1)], inorder[..curIdx]);
            cur.right = BuildTree(preorder[(curIdx + 1)..], inorder[(curIdx + 1)..]);
            return cur;
        }
    }
}