// Time: O(n)
// Space: O(n)
public class Solution {
    public string AddBinary(string a, string b) {
        var result = string.Empty;
        var aPointer = a.Length - 1;
        var bPointer = b.Length - 1;
        var carry = 0;
        
        while(aPointer >= 0 || bPointer >= 0)
        {
            int sum = carry;
            
            if(aPointer >= 0) sum += a[aPointer] - '0';
            if(bPointer >= 0) sum += b[bPointer] - '0';
            
            result = (sum % 2) + result;
            carry = sum > 1 ? 1 : 0;
            aPointer--;
            bPointer--;
        }
        
        if(carry == 1) result = 1 + result;
        return result;
    }
}