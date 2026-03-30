public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length;
        int count = n;
        void expand(int left, int right, ref int count)
        {
            while (left >= 0 && right < n && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            expand(i - 1, i + 1, ref count);
            expand(i - 1, i, ref count);
        }
        return count;
    }
}
