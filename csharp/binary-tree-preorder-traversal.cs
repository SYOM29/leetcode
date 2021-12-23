public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        return Traverse(root, new List<int>());
    }
    
    public IList<int> Traverse(TreeNode root, List<int> nodes)
    {
        if(root == null) return nodes;
        
        nodes.Add(root.val);
        Traverse(root.left, nodes);
        Traverse(root.right, nodes);
        return nodes;
    }
}