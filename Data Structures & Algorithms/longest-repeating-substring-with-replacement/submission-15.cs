public class Solution {
    public int CharacterReplacement(string s, int k) {
            int l = 0, m = 0, mf = 0;
            int[] freq = new int[26];
            for (int r = 0; r < s.Length; r++)
            {
                mf = Math.Max(mf, ++freq[s[r] - 'A']);
                if(r - l + 1 - mf > k)
                    freq[s[l++] - 'A']--;
                
                m = Math.Max(m, r - l + 1);
            }
            return m;
    }
}
