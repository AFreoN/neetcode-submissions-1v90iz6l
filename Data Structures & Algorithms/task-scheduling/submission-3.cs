public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];    // 'A' to 'Z'
        int mf = int.MinValue;
        foreach (char c in tasks)
        {
            if(++freq[c - 'A'] > mf)
                mf = freq[c - 'A'];
        }

        int fq = 0;
        foreach (int v in freq)
            if(v == mf) fq++;

        return Math.Max(tasks.Length, (mf - 1) * (n + 1) + fq);
    }
}
