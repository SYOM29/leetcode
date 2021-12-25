// Time: O(n)
// Space: O(1)
public class Solution {
    private Dictionary<char, int> _romanCharToIntMap = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },  
        { 'X', 10 },  
        { 'L', 50 },  
        { 'C', 100 },  
        { 'D', 500 },  
        { 'M', 1000 },  
    };
    
    private Dictionary<string, int> _romanStrToIntMap = new Dictionary<string, int>()
    {
        { "IV", 4 }, 
        { "IX", 9 },
        { "XL", 40 },
        { "XC", 90 },
        { "CD", 400 },
        { "CM", 900 },
    };
    
    public int RomanToInt(string s) {
        return ConvertToInt(s, 0);
    }
    
    public int ConvertToInt(string s, int val)
    {
        if (s == null || s.Length == 0) return val;

        if (s.Length == 1)
        {
            return val + IntToRoman(s);
        }

        var nextStartIdx = -1;

        if (s[0] != s[1])
        {
            // the "IV" case
            if (_romanStrToIntMap.ContainsKey(s.Substring(0, 2)))
            {
                val = val + IntToRoman(s.Substring(0, 2));
                nextStartIdx = 2;
            }
            // e.g: "MX" 
            else
            {
                val = val + IntToRoman(s.Substring(0, 1));
                nextStartIdx = 1;
            }
        }
        else
        {
            var count = 0;

            // if it is "III" calculate how many I's are there
            while (count + 1 <= s.Length - 1 && s[count] == s[count + 1])
            {
                count++;
            }

            val = val + (count + 1) * IntToRoman($"{s[0]}");
            nextStartIdx = count + 1;
        }

        if (nextStartIdx == -1 || nextStartIdx > s.Length - 1)
        {
            return val;
        }
        else
        {
            return ConvertToInt(s.Substring(nextStartIdx), val);
        }
    }
    
    public int IntToRoman(string s)
    {
        if(s == null || s.Length == 0) return 0;
        
        if(s.Length == 1)
        {
            return _romanCharToIntMap[s[0]];
        }
        else
        {
            return _romanStrToIntMap[s.Substring(0, 2)];
        }
    }
}