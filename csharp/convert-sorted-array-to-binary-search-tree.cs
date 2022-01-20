// Time: O(n)
// Space: O(n)
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length <= 1) return nums.Length == 0 ? null : new TreeNode(nums[0]);
        
        var mid = nums.Length % 2 == 0 ? nums.Length / 2 - 1 : nums.Length / 2;
        var root = new TreeNode(nums[mid]);
        
        var tempLeft = new int[mid];
        Array.Copy(nums, 0, tempLeft, 0, mid);
        root.left = SortedArrayToBST(tempLeft);
        
        var tempR = new int[nums.Length - mid - 1];
        Array.Copy(nums, mid + 1, tempR, 0, tempR.Length);
        root.right = SortedArrayToBST(tempR);
        
        return root;
    }
}

// Time: O(n)
// Space: O(n)
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        var n = nums.Length;
        if(n == 1) return new TreeNode(nums[0]);
        return ArrayToBST(nums, 0, n-1);
    }
    
    public TreeNode ArrayToBST(int[] nums, int offset, int len)
    {
        if(offset <= len)
        {
            int mid = (len - offset) / 2 + offset;
            var node = new TreeNode(nums[mid]);
            node.left = ArrayToBST(nums, offset, mid - 1);
            node.right = ArrayToBST(nums, mid + 1, len);
            return node;
        }
        return null;
    }
}