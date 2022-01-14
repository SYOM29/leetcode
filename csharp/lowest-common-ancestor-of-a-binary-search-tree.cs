// Time: O(log n)
// Space: O(1)
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root.val > p.val && root.val > q.val){
            return LowestCommonAncestor(root.left, p, q);
        }else if(root.val < p.val && root.val < q.val){
            return LowestCommonAncestor(root.right, p, q);
        }else{
            return root;
        }
    }
}

// Time: O(log n)
// Space: O(n)
public class Solution {
    private List<TreeNode> pNodePath = new List<TreeNode>();
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // search p and store its path
        BS(root, p);
        
        // search for q and set lca
        TreeNode lca = null;
        var curr = root;
        
        while(curr.val != q.val)
        {
            if(pNodePath.Contains(curr)) lca = curr;
            
            if(curr.val < q.val) curr = curr.right;
            else curr = curr.left;
        }
        
        if(pNodePath.Contains(curr)) lca = curr;
        
        return lca;
    }
    
    public void BS(TreeNode root, TreeNode node)
    {
        var curr = root;
        
        while(curr.val != node.val)
        {
            pNodePath.Add(curr);
            
            if(curr.val < node.val) curr = curr.right;
            else curr = curr.left;
        }
        pNodePath.Add(curr);
    }
}