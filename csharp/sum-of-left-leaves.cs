// Time: O(n)
// Space: O(1)
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return Sum(root, false);
    }
    
    public int Sum(TreeNode root, bool isLeft)
    {
        if(root == null) return 0;
        if(root.left == null && root.right == null) return isLeft ? root.val : 0;
        
        var left = Sum(root.left, true);
        var leftOnRight = Sum(root.right, false);
        
        return left + leftOnRight;
    }
}