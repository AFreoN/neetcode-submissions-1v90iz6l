public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        int start = 0;
        int max = 1;

        void expand(int left, int right, ref int start, ref int max)
        {
            while (left >= 0 && right < n && s[left] == s[right])
            {
                int m = right - left + 1;
                if(m > max)
                {
                    start = left;
                    max = m;
                }
                left--;
                right++;
            }
        }
        
        for(int i = 1; i < n; i++)
        {
            // odd palindrome
            expand(i - 1, i + 1, ref start, ref max);

            // even palindrome
            expand(i - 1, i, ref start, ref max);
        }

        return s.Substring(start, max);
    }
}
