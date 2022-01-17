// Time: O(n)
// Space: O(1)
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) return 0;

        var start = 0;
        var max = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] - prices[start] <= 0)
            {
                start = i;
            }
            else if (max < prices[i] - prices[start])
            {
                max = prices[i] - prices[start];
            }
        }

        return max;
    }
}