// Time: O(2^n)
// Space: O(2^n*n)
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        Backtrack(nums, new List<int>(), result, 0);
        return result;
    }
    
    public void Backtrack(int[] nums, List<int> tempList, List<IList<int>> result, int start)
    {
        result.Add(new List<int>(tempList));
        for(var i = start; i < nums.Length; i++)
        {
            tempList.Add(nums[i]);
            Backtrack(nums, tempList, result, i + 1);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}