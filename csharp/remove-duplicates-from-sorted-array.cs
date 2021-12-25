public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1) return nums.Length;

        var newLength = 1;
        var i = 1;
        var count = 1;
        while (count < nums.Length)
        {
            if (nums[i - 1] == nums[i]) Shift(nums, i);
            else
            {
                newLength++;
                i++;
            }
            count++;
        }

        return newLength;
    }
    
    public void Shift(int[] nums, int idx)
    {
        for(var i = idx; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        
        nums[nums.Length - 1] = int.MinValue;
    }
}