// Time: O(n^2)
// Space: O(n)
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        
        if(nums == null || nums.Length < 3) return result;
        
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(i == 0 || (nums[i] != nums[i - 1]))
            {
                int low = i + 1;
                int high = nums.Length - 1;
                
                while(low < high)
                {
                    var sum = nums[low] + nums[high] + nums[i];
                    if(sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        while(low < high && nums[low] == nums[low + 1]) low++;
                        while(low < high && nums[high] == nums[high - 1]) high--;
                        low++;
                        high--;
                    }
                    else if(sum < 0) low++;
                    else high--;
                }
            }
        }
        
        return result;
    }
}