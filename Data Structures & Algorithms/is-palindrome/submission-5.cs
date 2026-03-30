public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while(left < right)
        {
            if (!IsAlphaNumeric(s[left]))
            {
                left++;
                continue;
            }
            if (!IsAlphaNumeric(s[right]))
            {
                right--;
                continue;
            }

            char a = ToLower(s[left]);

            if (ToLower(s[left]) != ToLower(s[right])) return false;
            left++;
            right--;
        }

        return true; 
    }

    private bool IsAlphaNumeric(char c) =>
        (c is >= 'A' and <= 'Z') || (c is >= 'a' and <= 'z') || (c is >= '0' and <= '9');

    private char ToLower(char c) =>
        (c is >= 'A' and <= 'Z') ? (char)(c + 32) : c;
}
