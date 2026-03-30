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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null) return null;

        TreeNode parent = null;
        TreeNode curr = root;

        // 1. Find node to delete
        while(curr != null && curr.val != key)
        {
            parent = curr;
            if(key < curr.val) curr = curr.left;
            else curr = curr.right;
        }

        if(curr == null) return root;

        // 2. Handle delete node containing one child
        if(curr.left == null || curr.right == null)
        {
            TreeNode child = curr.left != null ? curr.left : curr.right;

            if(parent == null) return child;

            if(parent.left == curr) parent.left = child;
            else parent.right = child;

            return root;
        }

        // 3. Handle delete node containing two child
        TreeNode par = null;
        TreeNode delNode = curr;
        curr = curr.right;

        while(curr.left != null)
        {
            par = curr;
            curr = curr.left;
        }

        if(par != null)
        {
            par.left = curr.right;
            curr.right = delNode.right;
        }

        curr.left = delNode.left;

        if(parent == null) return curr;

        if(parent.left == delNode) parent.left = curr;
        else parent.right = curr;

        return root;
    }
}