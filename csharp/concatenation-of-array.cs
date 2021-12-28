// Time: O(n)
// Space: O(n)
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var vals = new int[2 * n];
        
        for(var i = 0; i < n; i++)
        {
            vals[i] = nums[i];
            vals[i + n] = nums[i];
        }
        
        return vals;
    }
}