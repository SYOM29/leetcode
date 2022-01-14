public class Solution {
    private Dictionary<char, List<char>> _digitToCharMap = new Dictionary<char, List<char>>()
    {
        { '2', new List<char>() { 'a', 'b', 'c' } },
        { '3', new List<char>() { 'd', 'e', 'f' } },    
        { '4', new List<char>() { 'g', 'h', 'i' } },    
        { '5', new List<char>() { 'j', 'k', 'l' } },    
        { '6', new List<char>() { 'm', 'n', 'o' } },    
        { '7', new List<char>() { 'p', 'q', 'r', 's' } },    
        { '8', new List<char>() { 't', 'u', 'v' } },    
        { '9', new List<char>() { 'w', 'x', 'y', 'z' } },    
    };
    
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        
        if(digits == null || digits.Length == 0) return result;
        
        Backtrack(digits, "", 0, result);
        return result;
    }
    
    public void Backtrack(string digits, string tempString, int currItem, List<string> result)
    {
        if(tempString.Length == digits.Length)
        {
            result.Add(tempString);
            return;
        }
        
        var possibleChars = _digitToCharMap[digits[currItem]];

        for(var j = 0; j < possibleChars.Count; j++)
        {
            tempString += possibleChars[j];
            Backtrack(digits, tempString, currItem + 1, result);
            tempString = tempString.Substring(0, tempString.Length - 1);
        }
    }
}