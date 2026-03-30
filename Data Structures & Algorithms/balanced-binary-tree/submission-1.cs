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
    public bool IsBalanced(TreeNode root) {
                        bool b = true;
            GetBalance(root, ref b);
            return b;
    }
    int GetBalance(TreeNode root, ref bool balanced)
    {
        if (!balanced || root == null) return 0;
        int left = GetBalance(root.left, ref balanced);
        int right = GetBalance(root.right, ref balanced);
        if (Math.Abs(left - right) > 1) balanced = false;
        return 1 + Math.Max(left, right);
    }
}
