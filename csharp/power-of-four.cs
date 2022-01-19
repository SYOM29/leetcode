// Time: O(1)
// Space: O(1)
public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n == 0 || n == int.MinValue || n == int.MaxValue) return false;
        return ((n & (n - 1)) == 0) && ((0x55555555 & n) > 0);
    }
}