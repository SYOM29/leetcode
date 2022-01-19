// Time: O(n)
// Space: O(1)
public class Solution {
    public char FindTheDifference(string s, string t) {
        if(s.Length == 0) return t[0];
        
        int missingChar = 0;
        for(var i = 0; i < t.Length; i++)
        {
            if(i < s.Length) missingChar -= s[i];
            missingChar += t[i];
        }
        
        return (char)missingChar;
    }
}