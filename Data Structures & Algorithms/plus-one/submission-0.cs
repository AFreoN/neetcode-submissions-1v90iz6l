public class Solution {
    public int[] PlusOne(int[] digits) {
            int n = digits.Length;
            int last = digits[n - 1] + 1;
            int rem = 0;
            if (last > 9)
            {
                digits[n - 1] = 0;
                rem = 1;
            }
            else
                digits[n - 1] = last;

            for (int i = n - 2; i >= 0; i--)
            {
                int v = digits[i] + rem;
                if (v > 9)
                {
                    rem = 1;
                    v = 0;
                }
                else rem = 0;
                digits[i] = v;
            }
            if(rem == 0) return digits;

            int[] res = new int[digits.Length + 1];
            res[0] = rem;
            for (int i = 1; i < res.Length; i++)
                res[i] = digits[i - 1];
            return res;
    }
}
