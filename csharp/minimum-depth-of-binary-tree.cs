// Time: O(n)
// Space: O(1)
public class Solution {
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        
        var left = MinDepth(root.left);
        var right = MinDepth(root.right);
        
        if(left == 0) return 1 + right;
        else if(right == 0) return 1 + left;

        return Math.Min(1 + left, 1 + right);
    }
}