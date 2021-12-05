// Most straightforward
// Time: O(n)
// Space O(1)
public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}

// Time: O(n)
// Space: O(n)
public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length == 1) return nums[0];
        
        var numDict = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(numDict.ContainsKey(nums[i]))
            {
                numDict[nums[i]] = numDict[nums[i]] + 1;
                
                if(numDict[nums[i]] > nums.Length / 2) return nums[i];
            }
            else
            {
                numDict.Add(nums[i], 1);
            }
        }
        
        return 0;
    }
}