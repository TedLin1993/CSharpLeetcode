namespace CSharpLeetcode.leetcode
{
    public class Validate_Binary_Tree_Nodes
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            var parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }
            int find(int idx)
            {
                if (parents[idx] == idx) return idx;
                parents[idx] = find(parents[idx]);
                return parents[idx];
            }
            void union(int parent, int child)
            {
                parent = find(parent);
                child = find(child);
                parents[child] = parent;
            }
            for (int i = 0; i < n; i++)
            {
                var left = leftChild[i];
                if (left != -1)
                {
                    if (find(left) != left || find(i) == left) return false;
                    union(i, left);
                }

                var right = rightChild[i];
                if (right != -1)
                {
                    if (find(right) != right || find(i) == right) return false;
                    union(i, right);
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (find(i - 1) != find(i)) return false;
            }
            return true;
        }
    }
}