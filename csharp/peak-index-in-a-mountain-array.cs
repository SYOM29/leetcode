// Time: O(log(n))
// Space: O(1)
public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int min = 0;
        int max = arr.Length - 1;
        
        while(min <= max)
        {
            int mid = (min + max) / 2;
            
            if(mid == 0) mid += 1;
            else if(mid == arr.Length - 1) mid -= 1;
            
            if(arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1]) return mid;
            else if(arr[mid] < arr[mid - 1])
            {
                max = mid - 1;
            }
            else
            {
                min = min + 1;
            }
        }
        
        return -1;
    }
}