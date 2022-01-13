// Time: O(n)
// Space: O(1)
public class Solution {
    public int TitleToNumber(string columnTitle) {
        int number = 0;
        
        for(int i = columnTitle.Length - 1; i >= 0; i--)
        {
            number += (int)Math.Pow(26, columnTitle.Length - i - 1) * GetValueOfChar(columnTitle[i]);
        }
        
        return number;
    }
    
    public int GetValueOfChar(char ch)
    {
        return ch - 'A' + 1;
    }
}