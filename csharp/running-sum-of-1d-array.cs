// Time: O(n)
// Space: O(n)
public class Solution {
    public int[] RunningSum(int[] nums) {
        var runningSum = new int[nums.Length];
        runningSum[0] = nums[0];
        
        for(var i = 1; i < nums.Length; i++)
        {
            runningSum[i] = runningSum[i-1] + nums[i];
        }
        
        return runningSum;
    }
}