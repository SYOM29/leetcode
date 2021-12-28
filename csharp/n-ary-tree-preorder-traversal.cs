// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> Preorder(Node root) {
        return PreorderTraversal(root, new List<int>());
    }
    
    public IList<int> PreorderTraversal(Node root, List<int> res)
    {
        if(root == null) return res;
        
        res.Add(root.val);
        
        foreach(var child in root.children)
        {
            PreorderTraversal(child, res);
        }
        
        return res;
    }
}