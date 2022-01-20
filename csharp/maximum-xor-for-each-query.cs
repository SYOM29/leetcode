// Time: O(n^2)
// Space: O(1)
public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        var result = new int[nums.Length];
        
        int xoredNums = XORArray(nums);
        
        for(int i = 0; i < nums.Length; i++)
        {
            var possibleBits = GetUnsetBits(xoredNums);
            var k = 0;
            
            for (int j = 0; j < possibleBits.Count; j++)
            {
                if (possibleBits[j] >= maximumBit) break;
                k |= (1 << possibleBits[j]);
            }
            
            result[i] = k;
            xoredNums = xoredNums ^ nums[nums.Length - 1 - i];
        }
        
        return result;
    }
    
    public List<int> GetUnsetBits(int num)
    {
        var result = new List<int>();
        
        for(int i = 0; i < 32; i++)
        {
            if( ((num >> i) & 1) == 0 ) result.Add(i);
        }
        
        return result;
    }
    
    public int XORArray(int[] nums)
    {
        int xor = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            xor ^= nums[i];
        }
        
        return xor;
    }
}