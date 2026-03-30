public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while(left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            char a = char.ToLower(s[left]);
            char b = char.ToLower(s[right]);
            if (!a.Equals(b)) return false;
            left++;
            right--;
        }

        return true; 
    }
}
