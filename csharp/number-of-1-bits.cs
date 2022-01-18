// Time: O(1)
// Space: O(1)
public class Solution {
    public int HammingWeight(uint n) {
        var ones = 0;
        
        for(var i = 0; i < 32; i++)
        {
            if((n & 1) == 1) ones++;
            n >>= 1;
        }
        
        return ones;
    }
}

// Time: O(1)
// Space: O(1)
public class Solution {
    public int HammingWeight(uint n) {
        var ones = 0;
        
        while(n > 0)
        {
            // iterate over 2's powers
            n &= (n-1);
            ones++;
        }
        
        return ones;
    }
}