// Time: O(n)
// Space: O(1)
public class Solution {
    public uint reverseBits(uint n) {
        var binary = string.Empty;

        while(n > 0)
        {
            binary += (n % 2);
            n /= 2;
        }

        while(binary.Length < 32)
        {
            binary += 0;
        }

        return Convert.ToUInt32(binary, 2);
    }
}

// Time: O(1) iteration number is fixed and is not dependent on input
// Space: O(1)
public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        
        for(var i = 0; i < 32; i++)
        {
            result <<= 1;
            if(n % 2 == 1) result++;
            n >>= 1;
        }
        
        return result;
    }
}