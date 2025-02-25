// time complexity - O(n)
// space complexity- O(n)
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        IList<int> res = new List<int>();
        if (root == null)
        {
            return res;
        }

        // BFS
        Queue<TreeNode> bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);
        while (bfs.Count() != 0)
        {
            int size = bfs.Count();
            int max = Int32.MinValue;
            while (size > 0)
            {
                TreeNode node = bfs.Dequeue();
                max = Math.Max(max, node.val);
                if (node.left != null)
                {
                    bfs.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    bfs.Enqueue(node.right);
                }
                size--;
            }
            res.Add(max);
        }
        return res;
    }
}