public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        return Traverse(root, new List<int>());
    }
    
    public IList<int> Traverse(TreeNode root, List<int> nodes)
    {
        if(root == null) return nodes;
        
        Traverse(root.left, nodes);
        Traverse(root.right, nodes);
        nodes.Add(root.val);
        return nodes;
    }
}