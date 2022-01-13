public class Solution {
    public bool IsHappy(int n) {
        var hashSet = new HashSet<int>();
        var sum = SumSquaresOfDigits(n);
        hashSet.Add(sum);
        
        while(sum != 1)
        {
            sum = SumSquaresOfDigits(sum);
            if(hashSet.Contains(sum)) return false;
            else hashSet.Add(sum);
        }
        
        return true;
    }
    
    public int SumSquaresOfDigits(int n)
    {
        var sum = 0;
        while(n > 0)
        {
            sum += (int)Math.Pow(n % 10, 2);
            n = n / 10;
        }
        return sum;
    }
}