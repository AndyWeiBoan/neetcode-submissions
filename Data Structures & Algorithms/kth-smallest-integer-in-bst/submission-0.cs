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
    public int KthSmallest(TreeNode root, int k) 
    {
    var buffer = new List<int>(k);
    Kth(root, buffer, k);
    return buffer[^1];
  }

  public void Kth(
      TreeNode root,
      List<int> buffer,
      int k)
  {
    if (root == null) return;

    Kth(root.left, buffer, k);
    if (buffer.Count < k)
    {
      buffer.Add(root.val);
      Kth(root.right, buffer, k);
    }
    return;
  }
}
