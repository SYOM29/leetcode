// Time: O(n)
// Space: O(1)
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var x = 0;
        
        foreach(var op in operations)
        {
            if(op.Equals("X++") || op.Equals("++X"))
            {
                x++;
            }
            else
            {
                x--;
            }
        }
        
        return x;
    }
}