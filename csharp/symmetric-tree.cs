// Time: O(n)
// Space: O(n)
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root.left == null && root.right == null) return true;
        var left = new Queue<TreeNode>();
        left.Enqueue(root.left);
        
        var right = new Queue<TreeNode>();
        right.Enqueue(root.right);
        
        return AreEqual(left, right);
    }
    
    public bool AreEqual(Queue<TreeNode> leftQueue, Queue<TreeNode> rightQueue)
    {
        if(leftQueue.Count == 0 && rightQueue.Count == 0) return true;
        
        var left = leftQueue.Dequeue();
        var right = rightQueue.Dequeue();
        
        if(left == null && right == null) return AreEqual(leftQueue, rightQueue);
        
        if((left == null && right != null) 
            || (left != null && right == null)
            || left.val != right.val) return false;
        
        leftQueue.Enqueue(left.left);
        leftQueue.Enqueue(left.right);

        rightQueue.Enqueue(right.right);        
        rightQueue.Enqueue(right.left);
        
        return AreEqual(leftQueue, rightQueue);
    }
}