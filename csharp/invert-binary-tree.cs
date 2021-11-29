// Time: O(n)
// Space: O(1)
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null || (root.left == null && root.right == null)) return root;
        
        var tempRoot = root;
        Inverter(tempRoot);
        return root;
    }
    
    public void Inverter(TreeNode root)
    {
        if(root == null) return;
        
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        Inverter(root.left);
        Inverter(root.right);
    }
}