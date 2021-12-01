// Time: O(n)
// Space: O(1)
public class Solution {
    public int MaxArea(int[] height) {
        int start = 0;
        int end = height.Length - 1;
        int maxArea = 0;
        
        while(start < end)
        {
            var currArea = (end - start) * (height[start] < height[end] ? height[start] : height[end]);
            
            if(maxArea < currArea) maxArea = currArea;
            
            if(height[start] < height[end]) start++;
            else end--;
        }
        
        return maxArea;
    }
}