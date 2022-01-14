// Time: O(n)
// Space: O(1)
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) return false;
        return DFS(root, 0, targetSum);
    }
    
    public bool DFS(TreeNode root, int currSum, int targetSum)
    {
        if(root == null) return false;
        if(root.left == null && root.right == null) return currSum + root.val == targetSum;
        return DFS(root.left, currSum + root.val, targetSum) || DFS(root.right, currSum + root.val, targetSum);
    }
}