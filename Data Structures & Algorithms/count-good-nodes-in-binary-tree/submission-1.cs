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
    public int GoodNodes(TreeNode root) {
        return DFS(root, int.MinValue);
    }

    int DFS(TreeNode node, int max)
    {
        if (node == null) return 0;

        int m = Math.Max(node.val, max);
        return (node.val >= max ? 1 : 0) + DFS(node.left, m) + DFS(node.right,m);
    }
}
