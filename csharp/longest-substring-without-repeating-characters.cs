// Time: O(n)
// Space: O(n)
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s.Length == 0) return 0;
        if(s.Length == 1) return 1;
        
        var max = 0;
        var e = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(var i = 0; i < s.Length; i++)
        {
            if(map.ContainsKey(s[i])) 
            {
                e = Math.Max(e, map[s[i]] + 1);
                map[s[i]] = i;
            }
            else
            {
                map.Add(s[i], i);
            }
            
            max = Math.Max(max, i - e + 1);
        }
        
        return max;
    }
}