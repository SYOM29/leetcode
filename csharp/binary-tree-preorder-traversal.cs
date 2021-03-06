// Recursive
// Time: O(n)
// Space: O(n)
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

// Iterative
// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();
        if(root == null) return result;
        
        var stack = new Stack<TreeNode>();
        var curr = root;
        
        while(curr != null || stack.Count > 0)
        {
            while(curr != null)
            {
                stack.Push(curr);
                result.Add(curr.val);
                curr = curr.left;
            }
            curr = stack.Pop();
            curr = curr.right;
        }
        
        return result;
    }
}