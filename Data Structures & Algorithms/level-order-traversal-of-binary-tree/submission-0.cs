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
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
            List<List<int>> r = new List<List<int>>();
            if (root == null) return r;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                List<int> L = new List<int>();

                for(int i = q.Count; i > 0; i--)
                {
                    TreeNode t = q.Dequeue();
                    if(t != null)
                    {
                        L.Add(t.val);
                        q.Enqueue(t.left);
                        q.Enqueue(t.right);
                    }
                }
                if(L.Count > 0)
                    r.Add(L);
            }
            return r;
    }
}
