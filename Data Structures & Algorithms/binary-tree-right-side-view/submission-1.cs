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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if (root == null) return res;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            int v = int.MinValue;
            for (int i = queue.Count; i > 0; i--)
            {
                TreeNode node = queue.Dequeue();
                if (node == null) continue;
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
                v = node.val;
            }
            if(v != int.MinValue) res.Add(v);
        }
        return res;
    }
}
