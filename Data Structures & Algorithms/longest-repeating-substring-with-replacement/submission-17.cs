public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0, maxFreq = 0, longest = 0;
        Span<int> freq = stackalloc int[26];

        for(int r = 0; r < s.Length; r++)
        {
            maxFreq = Math.Max(maxFreq, ++freq[s[r] - 'A']);

            int windowLength = r - l + 1;

            if(windowLength - maxFreq > k)
            {
                freq[s[l] - 'A']--;
                l++;
                windowLength--;
            }

            longest = Math.Max(longest, windowLength);
        }

        return longest;
    }
}
