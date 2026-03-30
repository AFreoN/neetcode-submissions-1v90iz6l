public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];    // 'A' to 'Z'
        foreach (char c in tasks)
            ++freq[c - 'A'];

        Array.Sort(freq);
        int max = freq[25];
        int maxFreqCount = Array.FindAll(freq, x => x == max).Length;

        return Math.Max(tasks.Length, (max - 1) * (n + 1) + maxFreqCount);
    }
}
