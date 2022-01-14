// Time: O(n)
// Space: O(n)
public class Solution {
   
    public int Reverse(int x)
    {
        if (x == 0) return 0;

        var resultAsString = ToString(x);

        if (GuardString(x, resultAsString) == 0) return 0;

        return Convert.ToInt32(resultAsString);
    }

    public int GuardString(int x, string s)
    {
        var max = int.MaxValue.ToString();
        var min = int.MinValue.ToString();

        if (x > 0)
        {
            if (s.Length > max.Length
               || (s.Length == max.Length && s.CompareTo(max) == 1)) return 0;
        }
        else
        {
            if (s.Length > min.Length
               || (s.Length == min.Length && s.CompareTo(min) == 1)) return 0;
        }

        return -1;
    }

    public string ToString(int x)
    {
        var str = x < 0 ? "-" : "";

        while (x != 0)
        {
            str += x % 10 * (x < 0 ? -1 : 1);
            x = x / 10;
        }

        return str;
    }
}