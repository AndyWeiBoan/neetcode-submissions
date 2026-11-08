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
    public bool IsValidBST(TreeNode root) 
    {
    return IsValidBST(root, long.MinValue, long.MaxValue);
  }

  public bool IsValidBST(TreeNode root, long min, long max)
  {
    if (root == null) return true;

    if (min < root.val && root.val < max)
    {
      return IsValidBST(root.left, min, root.val)
        && IsValidBST(root.right, root.val, max);
    }
    return false;
  }
}
