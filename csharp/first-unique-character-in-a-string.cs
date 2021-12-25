// Time: O(n)
// Space: O(n)
public class Solution {
    public int FirstUniqChar(string s) {
        var charMap = new Dictionary<char, int>();
        
        for(var i = 0; i < s.Length; i++)
        {
            if(charMap.ContainsKey(s[i])) charMap[s[i]] += 1;
            else
            {
                charMap.Add(s[i], 1);
            }
        }
        
        foreach(var key in charMap.Keys)
        {
            if(charMap[key] == 1) return s.IndexOf(key);
        }
        
        return -1;
    }
}