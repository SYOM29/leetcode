// Time: O(n log n)
// Space: O(1)
public class Solution {
    public int MaxProductDifference(int[] nums) {
        QuickSort(nums, 0, nums.Length - 1);
        return (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]);
    }
    
    public void QuickSort(int[] nums, int l, int h)
    {
        if(l < h)
        {
            var pivot = Partition(nums, l, h);
            QuickSort(nums, l, pivot - 1);
            QuickSort(nums, pivot + 1, h);
        }
    }
    
    public int Partition(int[] nums, int l, int h)
    {
        var pivot = nums[h];
        var j = l;
        
        for(var i = l; i < h; i++)
        {
            if(nums[i] < pivot)
            {
                Swap(nums, j, i);
                j++;
            }
        }
        Swap(nums, j, h);
        return j;
    }
    
    public void Swap(int[] nums, int i1, int i2)
    {
        var temp = nums[i1];
        nums[i1] = nums[i2];
        nums[i2] = temp;
    }
}