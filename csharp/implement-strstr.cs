// Time: O(n * m)
// Space: O(1)
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle)) return 0;
        if(string.IsNullOrEmpty(haystack)) return -1;
        
        for(var i = 0; i < haystack.Length; i++)
        {
            if(StartsWith(haystack.Substring(i), needle)) return i;
            
            if(haystack.Length - i + 1 < needle.Length) return -1;
        }
        
        return -1;
    }
    
    public bool StartsWith(string str, string prefix)
    {
        if(prefix.Length > str.Length) return false;
        
        for(var i = 0; i < prefix.Length; i++)
        {
            if(str[i] != prefix[i]) return false;
        }
        
        return true;
    }
}