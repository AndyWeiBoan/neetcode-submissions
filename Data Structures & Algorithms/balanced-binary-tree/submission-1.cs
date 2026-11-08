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
        return GetHeight(root).balanced;
    }

    public (bool balanced, int h) GetHeight(TreeNode root)
    {
        if (root == null) return (true, 0);
        var left = GetHeight(root.left);
        if (left.balanced == false) return (false, 0);
        var right = GetHeight(root.right);
        if (right.balanced == false) return (false, 0);
        if (1 < Math.Abs(left.h - right.h)) return (false, 0);
        return (true, 1+Math.Max(left.h, right.h));
    }
}
