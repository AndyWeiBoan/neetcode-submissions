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
    public int DiameterOfBinaryTree(TreeNode root) 
      {
    var res = GetHeight(root);

    return res.max;
  }

  public (int height, int max) GetHeight(TreeNode root)
  {
    if (root == null) return (-1, 0);

    var left = GetHeight(root.left);
    var right = GetHeight(root.right);
    var left_h = 1 + left.height;
    var right_h = 1 + right.height;
    var h = Math.Max(left_h, right_h);
    var m = Math.Max(left.max, right.max);
    m = Math.Max(m, left_h + right_h);
    return (h, m);
  }

}
