// Using binary search
// Time: O(n log(n))
// Space: O(1)
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length == 2) return new int[2] {1,2};
        
        for(var i = 0; i < numbers.Length; i++)
        {
            var index = BinarySearch(numbers, target - numbers[i], i);
            
            if(index != -1) return new int[2] { i + 1, index + 1 };
        }
        
        return  new int[2] { -1, -1 };
    }
    
    public int BinarySearch(int[] nums, int target, int i)
    {
        int min = i+1;
        int max = nums.Length - 1;
        
        while(min <= max)
        {
            int mid = (min + max) / 2;
            
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(target > nums[mid]) 
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        
        return -1;
    }
}