// Time: O(n)
// Space: O(n)
public class Solution {
    public void Flatten(TreeNode root) {
        if(root == null || (root.right == null && root.left == null)) return;
        
        var queue = Traverse(root, new Queue<int>());
        
        queue.Dequeue();
        while(queue.Count() > 0)
        {
            root.left = null;
            root.right = new TreeNode(queue.Dequeue());
            root = root.right;
        }
    }
    
    public Queue<int> Traverse(TreeNode root, Queue<int> queue)
    {
        if(root == null) return queue;
        
        queue.Enqueue(root.val);
        Traverse(root.left, queue);
        Traverse(root.right, queue);
        return queue;
    }
}