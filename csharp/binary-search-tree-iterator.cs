// Time: O(n)
// Space: O(n)
public class BSTIterator {
    private TreeNode _root;
    private int _pointer = 0;
    private List<int> _flattenedTree = new List<int>();
    
    public BSTIterator(TreeNode root) {
        _root = root;
        var temp = _root;
        FlattenTree(temp);
    }
    
    public int Next() {
        var node = _flattenedTree[_pointer];
        _pointer++;
        return node;
    }
    
    public bool HasNext() {
        return _pointer != _flattenedTree.Count;
    }
    
    private void FlattenTree(TreeNode root)
    {
        if(root == null) return;
        
        FlattenTree(root.left);
        _flattenedTree.Add(root.val);
        FlattenTree(root.right);
    }
}