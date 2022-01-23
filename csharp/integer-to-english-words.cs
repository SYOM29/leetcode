// Time: O(n)
// Space: O(1)
public class Solution {
    private Dictionary<int, string> _numToWordMap = new Dictionary<int, string>()
    {
        { 0, "Zero" },
        { 1, "One" },
        { 2, "Two" },
        { 3, "Three" },
        { 4, "Four" },
        { 5, "Five" },
        { 6, "Six" },
        { 7, "Seven" },
        { 8, "Eight" },
        { 9, "Nine" },
        { 10, "Ten" },
        { 11, "Eleven" },
        { 12, "Twelve" },
        { 13, "Thirteen" },
        { 14, "Fourteen" },
        { 15, "Fifteen" },
        { 16, "Sixteen" },
        { 17, "Seventeen" },
        { 18, "Eighteen" },
        { 19, "Nineteen" },
        { 20, "Twenty" },
        { 30, "Thirty" },
        { 40, "Forty" },
        { 50, "Fifty" },
        { 60, "Sixty" },
        { 70, "Seventy" },
        { 80, "Eighty" },
        { 90, "Ninety" },
        { 100, "Hundred" },
        { 1000, "Thousand" },
        { 1000000, "Million" },        
        { 1000000000, "Billion" },
    };
    
    public string NumberToWords(int num) {
        if(num == 0) return _numToWordMap[0];
        return NumToWords(num, "");
    }
    
    public string NumToWords(int num, string currNum)
    {
        if(num <= 0) return currNum;
        
        if(num <= 20) return $"{_numToWordMap[num]}";
        else if(num < 100)
        {
            int divisor = GetDivisor(num);
            int i = num / divisor;
            num = num - (i * divisor);
            currNum += $"{_numToWordMap[i * divisor]}";
            if(num > 0) currNum += $" {NumToWords(num, string.Empty)}";
        }
        else
        {
            int divisor = GetDivisor(num);
            int i = num / divisor;
            num = num - (i * divisor);
            currNum += $"{NumToWords(i, currNum)} {_numToWordMap[divisor]}";
            if(num > 0) currNum += $" {NumToWords(num, string.Empty)}";
        }
        
        return currNum;
    }
    
    public int GetDivisor(int num)
    {
        if(num < 100) return 10;
        else if(num < 1000) return 100;
        else if(num < 1000000) return 1000;
        else if(num < 1000000000) return 1000000;
        else return 1000000000;
    }
}