// Time: O(n log n)
// Space: O(1)
public class Solution {
    public int MissingNumber(int[] nums) {
        QuickSort(nums, 0, nums.Length - 1);
          
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] != i)
            {
                return i;
            }
        }
        
        return nums.Length;
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
                Swap(nums, i, j);
                j++;
            }
        }
        Swap(nums, h, j);
        return j;
    }
    
    public void Swap(int[] nums, int p1, int p2)
    {
        var temp = nums[p1];
        nums[p1] = nums[p2];
        nums[p2] = temp;
    }
}