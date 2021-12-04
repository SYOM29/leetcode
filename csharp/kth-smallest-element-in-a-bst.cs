// Time: O(n)
// Space: O(1)
public class Solution {
    private int goal = int.MinValue;
    public int KthSmallest(TreeNode root, int k) {
        InOrderKth(root, k, 1);
        return goal;
    }
    
    public int InOrderKth(TreeNode root, int k, int i)
    {
        if (root == null) return i;

        i = InOrderKth(root.left, k, i);

        if (goal == int.MinValue && k == i)
        {
            goal = root.val;
            return i;
        }

        i++;
        i = InOrderKth(root.right, k, i);
        return i;
    }
}