public class Solution {
    public int[] CountBits(int n) {
        int[] bits = new int[n + 1];
        int offset = 1;
        for(int i = 1; i <= n; i++)
        {
            if(offset * 2 == i)
                offset = i;
            bits[i] = 1 + bits[i - offset];
        }
        return bits;
    }
}
