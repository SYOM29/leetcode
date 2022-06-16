public class Solution {
    public int GetSum(int a, int b) {
            if (a == 0 && b == 0) return 0;

            var mask = 1;
            var sum = 0;
            var carry = 0;
            
            for (int i = 0; i < 32; i++)
            {
                if (i == 31 && a <= 0 && b <= 0)
                {
                    sum = 1 << 31 | sum;
                    break;
                }

                if (carry > 0)
                {
                    sum = sum ^ carry;
                    carry = 0;
                }

                var aMask = a & mask;
                var bMask = b & mask;

                if (aMask != 0 && bMask != 0)
                {
                    sum = sum | (aMask ^ bMask);
                    carry = ((a & mask) & (b & mask)) << 1;
                }
                else if(i != 31 && aMask != 0)
                {
                    carry = (aMask & sum) << 1;
                    sum = sum ^ aMask;
                }
                else if (i != 31 && bMask != 0)
                {
                    carry = (bMask & sum) << 1;
                    sum = sum ^ bMask;
                }

                mask = mask << 1;
            }

            return sum;
    }
}