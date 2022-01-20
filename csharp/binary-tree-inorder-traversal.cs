// Recursive
// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        return Inorder(root, new List<int>());
    }
    
    public IList<int> Inorder(TreeNode root, IList<int> result)
    {
        if(root == null) return result;
        
        Inorder(root.left, result);
        result.Add(root.val);
        Inorder(root.right, result);
        return result;
    }
}

// Iterative
// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        
        if(root == null) return result;
        
        var stack = new Stack<TreeNode>();
        var curr = root;
        
        while(curr != null || stack.Count > 0)
        {
            while(curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            result.Add(curr.val);
            curr = curr.right;
        }
        
        return result;
    }
}