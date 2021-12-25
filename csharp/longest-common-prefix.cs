// Time: O(n)
// Space: O(n) where n is max char length of strs
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0) return string.Empty;
        
        var p1 = 0;
        var p2 = strs.Length - 1;
        var charIdx = 0;
        var prefix = "";
        
        while(charIdx < strs[p1].Length 
              && charIdx < strs[p2].Length 
              && strs[p1][charIdx] == strs[p2][charIdx])
        {
            prefix = prefix + strs[p1][charIdx];
            charIdx++;
        }
        
        if(string.IsNullOrEmpty(prefix)) return string.Empty;
        
        for(var i = 1; i <= strs.Length - 2; i++)
        {
            if(strs[i].StartsWith(prefix)) continue;
            
            while(prefix.Length != 0 && !strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
            
            if(string.IsNullOrEmpty(prefix)) return string.Empty;
        }
        
        return prefix;
    }
}