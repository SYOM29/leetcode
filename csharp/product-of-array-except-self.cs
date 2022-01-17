// Time: O(n)
// Space: O(1)
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var result = new int[n];
        Array.Fill(result, 1);
        
        // do one iteration to the right
        for (var i = 1; i < n; i++)
        {   
            result[i] *= result[i-1] * nums[i-1];
        }
        
        // do one iteration to the left
        var right = 1;
        for (var i = n - 1; i > -1; i--)
        {
            result[i] *= right;
            right *= nums[i]; 
        }
        
        return result;
    }
}