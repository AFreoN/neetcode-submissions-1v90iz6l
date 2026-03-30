public class Solution {
    public int Reverse(int x) {
        int r = 0;
        try
        {
            while(x != 0)
            {
                x = Math.DivRem(x, 10, out int rem);
                r = checked(r * 10 + rem);
            }
        }
        catch(OverflowException e)
        {
            return 0;
        }
        return r;
    }
}
