// Time: O(n)
// Space: O(n)
public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        var result = new List<string>();
        DFS(root, result, "");
        return result;
    }
    
    public void DFS(TreeNode root, List<string> result, string currString)
    {
        if(root == null) return;
        
        currString = AddToString(currString, root.val);
        
        if(root.left == null && root.right == null) 
        {
            result.Add(currString);
            return;
        }
        
        DFS(root.left, result, currString);
        DFS(root.right, result, currString);        
    }
    
    public string AddToString(string s, int val)
    {
        if(s.Length == 0) return s + val;
        else return s + "->" + val;
    }
}