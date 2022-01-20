// Time: O(log n)
// Space: O(1)
public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        var node = new TreeNode(val);
        if(root == null) return node;
        
        TreeNode prev = null;
        var curr = root;
        while(curr != null)
        {
            prev = curr;
            curr = curr.val > val ? curr.left : curr.right;
        }
        
        if(prev.val > val) prev.left = node;
        else prev.right = node;
        
        return root;
    }
}