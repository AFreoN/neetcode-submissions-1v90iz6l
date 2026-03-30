public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> hash = new HashSet<int>();
        while(!hash.Contains(n))
        {
            hash.Add(n);
            n = GetDigitSquare(n);
            if (n == 1) return true;
        }
        return false;
    }

    int GetDigitSquare(int n)
    {
        int r = 0;
        while(n != 0)
        {
            int rem = n % 10;
            n = n / 10;
            r += (rem * rem);
        }
        return r;
    }
}
