// Method: Dynamic Programming
// Time: O(n)
// Space: O(n)
public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n;
        
        var dpArr = new int[n + 1];
        Array.Fill(dpArr, 0);
        dpArr[1] = 1;
        dpArr[2] = 2;
        
        for(var i = 3; i <= n; i++)
        {
            dpArr[i] = dpArr[i - 1] + dpArr[i - 2];
        }
        
        return dpArr[n];
    }
}