public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0, m = 0, mf = 0;
        int[] freq = new int[26];
        for (int r = 0; r < s.Length; r++)
        {
            mf = Math.Max(mf, ++freq[s[r] - 'A']);
            int w = r - l + 1;
            if(w - mf > k)
            {
                freq[s[l++] - 'A']--;
                w--;
            }
            m = Math.Max(m, w);
        }
        return m;
    }
}
