// Courtesy of: https://leetcode.com/problems/longest-palindromic-substring/discuss/2928/Very-simple-clean-java-solution
// Time: O(n^2)
// Space: O(1)
public class Solution {
    private int low = 0;
    private int maxLen = int.MinValue;
    
    public string LongestPalindrome(string s) {
        if(s == null || s.Length < 2) return s;
        
        for(var i = 0; i < s.Length; i++)
        {
            ExtendPalindrome(s, i, i);      // in case palindrome length is odd, ex: racecar
            ExtendPalindrome(s, i, i + 1);  // in case palindrome length is even, ex: bb 
        }
        
        return s.Substring(low, maxLen);
    }
    
    public void ExtendPalindrome(string s, int start, int end)
    {
        while(start >= 0 && end < s.Length && s[start] == s[end])
        {
            start--;
            end++;
        }
        
        if(maxLen < end - start - 1)
        {
            low = start + 1;
            maxLen = end - start - 1;
        }
    }
}
