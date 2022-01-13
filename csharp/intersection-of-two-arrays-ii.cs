// Time: O(n)
// Space: O(n)
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0) return null;
        
        var dict = new Dictionary<int, int>();
        
        for(var i = 0; i < nums1.Length; i++)
        {
            if(dict.ContainsKey(nums1[i])) dict[nums1[i]] = dict[nums1[i]] + 1;
            else dict.Add(nums1[i], 1);
        }
        
        var result = new List<int>();
        for(var i = 0; i < nums2.Length; i++)
        {
            if(dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                dict[nums2[i]] = dict[nums2[i]] - 1;
            }
        }
        
        return ToArray(result);
    }
    
    public int[] ToArray(List<int> nums)
    {
        var newNums = new int[nums.Count];
        
        for(var i = 0; i < nums.Count; i++)
        {
            newNums[i] = nums[i];
        }
        
        return newNums;
    }
}