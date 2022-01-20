// Recursive
// Time: O(n)
// Space: O(n)
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

// Iterative
// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        
        if(root == null) return result;
        
        var stack = new Stack<TreeNode>();
        var curr = root;
        
        while(curr != null || stack.Count > 0)
        {
            while(curr != null)
            {
                stack.Push(curr);
                result.Insert(0, curr.val);
                curr = curr.right;
            }
            curr = stack.Pop();
            curr = curr.left;
        }
        
        return result;
    }
}