// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> Postorder(Node root) {
        return PostOrderTraversal(root, new List<int>());
    }
    
    public IList<int> PostOrderTraversal(Node root, List<int> res)
    {
        if(root == null) return res;
        
        foreach(var child in root.children)
        {
            PostOrderTraversal(child, res);
        }
        res.Add(root.val);
        return res;
    }
}