// Time: O(n)
// Space: O(n)
public class Solution {
    public int[] PlusOne(int[] digits) {
        var currIdx = digits.Length - 1;
        digits[currIdx] += 1;
        
        if(digits[currIdx] < 10) return digits;
        
        digits[currIdx] = 0;
        currIdx--;
        while(currIdx >= 0 && digits[currIdx] + 1 == 10)
        {
            digits[currIdx] = 0;
            currIdx--;
        }
        
        if(currIdx == -1)
        {
            return CreateNew(digits);
        }
        
        digits[currIdx] += 1;
        return digits;
    }
    
    public int[] CreateNew(int[] prevArr)
    {
        var arr = new int[prevArr.Length + 1];
        Array.Fill(arr, 0);
        arr[0] = 1;
        return arr;
    }
}