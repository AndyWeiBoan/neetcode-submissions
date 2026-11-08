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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) 
    {
    var current = root;
    var stack = new Stack<TreeNode>();

    while (stack.Count > 0 || current != null)
    {
      current = current ?? stack.Pop();
      if (IsSame(current, subRoot)) return true;
      if (current.right != null) stack.Push(current.right);
      current = current.left;
    }
    return false;
  }

  public bool IsSame(TreeNode root, TreeNode subRoot)
  {
    if (root == null && subRoot == null) return true;
    if (root != null && subRoot != null
        && root.val == subRoot.val)
    {
      return IsSame(root.left, subRoot.left)
        && IsSame(root.right, subRoot.right);
    }
    return false;
  }

}
