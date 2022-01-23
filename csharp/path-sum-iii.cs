// Time: O(n^2)
// Space: O(n) - stack
public class Solution {
    public int PathSum(TreeNode root, int targetSum)
    {
        if (root == null) return 0;
        return DFS(root, targetSum, targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
    }

    public int DFS(TreeNode root, int initialTargetSum, int targetSum)
    {
        if (root == null) return 0;
        var count = root.val == targetSum ? 1 : 0;
        count += DFS(root.left, initialTargetSum, targetSum - root.val) + DFS(root.right, initialTargetSum, targetSum - root.val);
        return count;
    }
}