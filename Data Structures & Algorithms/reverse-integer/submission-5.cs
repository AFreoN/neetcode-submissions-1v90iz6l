public class Solution {
    const int MIN = int.MinValue;
    const int MAX = int.MaxValue;
    public int Reverse(int x) {
        int r = 0;
        while(x != 0)
        {
            x = Math.DivRem(x, 10, out int digit);

            if (r > MAX / 10 || (r == MAX / 10 && digit > MAX % 10)) return 0;
            if (r < MIN / 10 || (r == MIN / 10 && digit < MIN % 10)) return 0;
            r = (r * 10) + digit;
        }
        return r;
    }
}
