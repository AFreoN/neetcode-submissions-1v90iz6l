public class Solution {
    public bool ValidPalindrome(string s) {
        if(s.Length < 3) return true;
        int l = 0, r = s.Length - 1;
        while(l < r)
        {
            if(s[l] != s[r])
                return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
            
            l++; r--;
        }
        return true;
    }

    bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left++] != s[right--])
                return false;
        }
        return true;
    }
}