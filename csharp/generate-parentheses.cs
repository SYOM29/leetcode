// Using Backtracking
public class Solution {
    private char[] _parentheses = new char[2] { '(', ')' }; 
    
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        Backtrack(n, "", 0, 0, result);
        return result;
    }
    
    public void Backtrack(int n, string tempString, int open, int close, List<string> result)
    {
        if(n * 2 == tempString.Length)
        {
            result.Add(tempString);
            return;
        }
        
        if(open < n) Backtrack(n, tempString + '(', open + 1, close, result);
        if(close < open) Backtrack(n, tempString + ')', open, close + 1, result);
    }
}