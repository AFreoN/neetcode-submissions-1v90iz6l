public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> hash = new List<char>();
        int m = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(hash.Contains(s[i]))
            {
                int index = hash.IndexOf(s[i]);
                // hash.RemoveRange(0, index + 1);
                while(index >= 0)
                {
                    hash.RemoveAt(index);
                    index--;
                }
            }
            
            hash.Add(s[i]);
            m = Math.Max(m, hash.Count);
        }
        return m;
    }
}
