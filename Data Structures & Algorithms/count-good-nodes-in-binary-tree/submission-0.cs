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
        if (root == null) return 0;
        int r = 0;
        DFS(root, int.MinValue, ref r);
        return r;
    }

    void DFS(TreeNode node, int max, ref int r)
    {
        if(node == null) return;
        if(node.val >= max)
        {
            r++;
            DFS(node.left, node.val, ref r);
            DFS(node.right, node.val, ref r);
        }
        else
        {
            DFS(node.left, max, ref r);
            DFS(node.right, max, ref r);
        }
    }
}
