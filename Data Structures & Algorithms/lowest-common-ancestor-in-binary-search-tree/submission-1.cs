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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (p.val > q.val) (p, q) = (q, p);
        while(root != null)
        {
            if (q.val < root.val) root = root.left;
            else if (p.val > root.val) root = root.right;
            else return root;
        }
        return root;
    }
}
