// Time: O(n*m)
// Space: O(1)
public class Solution {
    public int MostWordsFound(string[] sentences) {
        var max = 0;
        
        foreach(var sentence in sentences)
        {
            var curr = 1;
            
            for(var i = 1; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ' && sentence[i-1] != ' ') curr++;
            }
            
            if(curr > max) max = curr;
        }
        
        return max;
    }
}