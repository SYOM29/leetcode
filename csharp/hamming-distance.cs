// Time: O(1)
// Space: O(1)
public class Solution {
    public int HammingDistance(int x, int y) {
        var xXORy = x ^ y;
        int count = 0;
        
        while(xXORy > 0)
        {
            count++;
            xXORy &= (xXORy - 1);
        }
        return count;
    }
}