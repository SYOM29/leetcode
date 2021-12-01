// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        if(root == null) return ans;
        
        ans.Add(new List<int>() { root.val });
        if(root.left == null && root.right == null) return ans;
        
        var queue = new Queue<List<TreeNode>>();
        var levelNodes = new List<TreeNode>();
        if(root.left != null) levelNodes.Add(root.left);
        if(root.right != null) levelNodes.Add(root.right);
        queue.Enqueue(levelNodes);
        
        return GetValuesByLevel(queue, ans);
    }
    
    public IList<IList<int>> GetValuesByLevel(Queue<List<TreeNode>> nodes, IList<IList<int>> ans)
    {
        if(nodes.Count == 0) return ans;
        
        IList<int> vals = new List<int>();
        var levelNodes = new List<TreeNode>();
        List<TreeNode> tempNodes = nodes.Dequeue(); 
        
        for(var i = 0; i < tempNodes.Count; i++)
        {
            TreeNode temp = tempNodes.ElementAtOrDefault(i);
            vals.Add(temp.val);
            if(temp.left != null) levelNodes.Add(temp.left);
            if(temp.right != null) levelNodes.Add(temp.right); 
        }
        
        if(vals.Count != 0) ans.Add(vals);
        if(levelNodes.Count != 0) nodes.Enqueue(levelNodes);
        
        return GetValuesByLevel(nodes, ans);
    }
}