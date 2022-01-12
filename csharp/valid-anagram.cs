// Time: O(n)
// Space: O(n)
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        var charCounts = new int[26];
        Array.Fill(charCounts, 0);
        
        for(var i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a'] += 1;
            charCounts[t[i] - 'a'] -= 1;
        }
        
        for(var i = 0; i < charCounts.Length; i++)
        {
            if(charCounts[i] != 0) return false;
        }
        
        return true;
    }
}