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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return IsSame(p, q);
    }

            bool IsSame(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null) return true;
            int v1 = n1 != null ? n1.val : 101;
            int v2 = n2 != null ? n2.val : 101;
            if (v1 != v2) return false;

            bool left = IsSame(n1.left, n2.left);
            if(!left) return false;
            bool right = IsSame(n1.right, n2.right);
            if(!right) return false;

            return true;
        }
}
