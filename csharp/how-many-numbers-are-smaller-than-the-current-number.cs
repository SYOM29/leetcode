// Time: O(n)
// Space: O(1) counts is of fixed size since the limits of each element of array are fixed to 0<=nums[i]<=100
public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var counts = GetCounts(nums);
        
        var results = new int[nums.Length];
        
        for(var i = 0; i < nums.Length; i++)
        {
            results[i] = counts[nums[i]];
        }
        
        return results;
    }
    
    public int[] GetCounts(int[] nums)
    {
        var counts = new int[102];
        Array.Fill(counts, 0);
        
        for(var i = 0; i < nums.Length; i++)
        {
            counts[nums[i] + 1] += 1;
        }
        
        for(var i = 1; i < counts.Length; i++)
        {
            counts[i] += counts[i - 1];
        }
        
        return counts;
    }
}