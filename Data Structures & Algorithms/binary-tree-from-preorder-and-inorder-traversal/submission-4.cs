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
    int pId = 0, iId = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) => DFS(preorder, inorder, int.MaxValue);

    TreeNode DFS(int[] po, int[] io, int Limit)
    {
        if (pId >= po.Length) return null;
        if (io[iId] == Limit)
        {
            iId++;
            return null;
        }
        TreeNode t = new TreeNode(po[pId++]);
        t.left = DFS(po, io, t.val);
        t.right = DFS(po, io, Limit);
        return t;
    }
}
