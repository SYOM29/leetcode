// Time: O(n)
// Space: O(n)
public class Solution {
    public bool IsPalindrome(string s) {
        if(s == null) return false;
        if(s.Length <= 1) return true;
        
        var newStr = CleanData(s);   
        
        if(string.IsNullOrWhiteSpace(newStr)) return true;
        
        var p1 = 0;
        var p2 = newStr.Length - 1;
        
        while(p1 < p2)
        {
            if(newStr[p1] != newStr[p2]) return false;
            p1++;
            p2--;
        }
        
        return true;
    }
    
    public string CleanData(string s)
    {
        var newStr = string.Empty;
        
        for(var i = 0; i < s.Length; i++)
        {
            if(Char.IsLetterOrDigit(s[i])) newStr += $"{s[i]}".ToLower();
        }
        
        return newStr;
    }
}