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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        void dfs(TreeNode node)
        {
            if (node == null) return;
            dfs(node.left);
            dfs(node.right);
            result.Add(node.val);
        }
        dfs(root);
        return result;
    }
}