public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        int start = 0;
        int max = 1;

        for(int i = 1; i < n; i++)
        {
            //Lets do odd palindrome
            int left = i - 1, right = i + 1;
            while(left >= 0 && right < n && s[left] == s[right])
            {
                int m = right - left + 1;
                if(m > max)
                {
                    max = m;
                    start = left;
                }
                left--;
                right++;
            }

            //Lets do even palindrome
            left = i - 1; right = i;
            while(left >= 0 && right < n && s[left] == s[right])
            {
                int m = right - left + 1;
                if(m > max)
                {
                    max = m;
                    start = left;
                }
                left --;
                right++;
            }
        }

        return s.Substring(start, max);
    }
}
