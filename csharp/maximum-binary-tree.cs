// Time: O(n log n)
// Space: O(1)
public class Solution {
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Construct(nums, 0, nums.Length - 1);
    }
    
    public TreeNode Construct(int[] nums, int l, int h)
    {
        if(l > h) return null;
        
        var maxIdx = GetMaxIdx(nums, l, h);
        return new TreeNode(nums[maxIdx], Construct(nums, l, maxIdx - 1), Construct(nums, maxIdx + 1, h));
    }
    
    public int GetMaxIdx(int[] nums, int l, int h)
    {
        var maxIdx = -1;
        var max = int.MinValue;
        
        for(var i = l; i <= h; i++)
        {
            if(nums[i] > max)
            {
                max = nums[i];
                maxIdx = i;
            }
        }
        
        return maxIdx;
    }
}