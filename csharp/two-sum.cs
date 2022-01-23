// Time: O(n)
// Space: O(n)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i])) return new int[] { i, dict[nums[i]] };
            if(!dict.ContainsKey(target - nums[i])) dict.Add(target - nums[i], i);
        }
        
        return null;
    }
}