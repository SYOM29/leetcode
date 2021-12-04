// Time: O(n)
// Space: O(1)
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return Validate(root);
    }
    
    public bool Validate(TreeNode root, long min = long.MaxValue, long max = long.MinValue)
    {
        if(root == null) return true;
        
        if(root.val >= min || root.val <= max) return false;
        
        return Validate(root.left, Math.Min(min, root.val), max) 
            && Validate(root.right, min, Math.Max(max, root.val));
    }
}