public class Solution {
    public bool CheckInclusion(string s1, string s2) {
            int l = 0, t = s1.Length;
            Span<int> freq = stackalloc int[26];
            foreach (char c in s1)
                freq[c - 'a']++;

            for(int r = 0; r < s2.Length; r++)
            {
                freq[s2[r] - 'a']--;

                if (r - l + 1 > t)
                    freq[s2[l++] - 'a']++;
                
                if(r - l + 1 == t)
                {
                    int i = 0;
                    while (i < 26 && freq[i] == 0)
                        i++;

                    if (i == 26) return true;
                }
            }

            return false;
    }
}
