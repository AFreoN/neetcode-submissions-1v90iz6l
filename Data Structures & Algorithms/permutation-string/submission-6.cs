public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l = 0, t = s1.Length, r = t - 1;
        char[] a = new char[26];
        foreach (char c in s1)
            a[c - 'a']++;
        while (r < s2.Length)
        {
            char[] b = new char[26];
            int i = l;
            while(i <= r)
            {
                b[s2[i++] - 'a']++;
            }

            if (a.SequenceEqual(b))
                return true;

            l++;
            r++;
        }
        return false;
    }
}
