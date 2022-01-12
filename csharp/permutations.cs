// Time: O(n!/((N-k)!))
// Space: O(n!)
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        if(nums == null) return null;
        
        var result = new List<IList<int>>();
        Backtrack(nums, new List<int>(), result);
        return result;
    }
    
    public void Backtrack(int[] nums, List<int> tempList, List<IList<int>> perms)
    {
        if(tempList.Count == nums.Length)
        {
            perms.Add(new List<int>(tempList));
            return;
        }
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(tempList.Contains(nums[i])) continue;
            
            tempList.Add(nums[i]);
            Backtrack(nums, tempList, perms);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}