// Time: O(1)
// Space: O(1)
public class Solution {
    public int FindComplement(int num) {
        var msb = 31;
        while(num >> msb != 1)
        {
            msb--;
        }

        return ~num & ~(int.MaxValue << msb) & int.MaxValue;
    }
}