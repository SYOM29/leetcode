// Time: O(n)
// Space: O(1)
public class Solution {
    public bool IsUnivalTree(TreeNode root) {
        if(root == null || (root.left == null && root.right == null)) return true;
        return IsUnival(root, root.val);
    }
    
    public bool IsUnival(TreeNode root, int val)
    {
        if(root == null) return true;
        if(root.val != val) return false;
        return IsUnival(root.left, val) && IsUnival(root.right, val);
    }
}