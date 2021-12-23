// Algorithm: Quick Select
// Time: O(n) - Average, O(n^2) - Worst
// Space: O(1)
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return QuickSelect(nums, k - 1, 0, nums.Length - 1);
    }
    
    public int QuickSelect(int[] nums, int k, int l, int h)
    {
        var pivot = Partition(nums, l, h);
        
        if(pivot == k) return nums[pivot];
        else if(pivot < k) return QuickSelect(nums, k, pivot + 1, h);
        else return QuickSelect(nums, k, l, pivot - 1);
    }
    
    public int Partition(int[] nums, int l, int h)
    {
        var pivot = nums[h];
        var j = l;
        
        for(var i = l; i < h; i++)
        {
            if(nums[i] > pivot)
            {
                Swap(nums, i, j);
                j++;
            }
        }
        Swap(nums, h, j);
        return j;
    }
    
    public void Swap(int[] nums, int i1, int i2)
    {
        var temp = nums[i1];
        nums[i1] = nums[i2];
        nums[i2] = temp;
    }
}