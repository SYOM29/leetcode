// Time: O(n)
// Space: O(1)
public class Solution {
    private bool res = true;
    
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        Height(root);
        return res;
    }
    
    public int Height(TreeNode root)
    {
        if(root == null) return 0;
        
        var left = 1 + Height(root.left);
        var right = 1 + Height(root.right);
        
        if(Math.Abs(left - right) > 1) res = false;
        
        return Math.Max(left, right);
    }
}