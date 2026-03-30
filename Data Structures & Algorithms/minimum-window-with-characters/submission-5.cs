public class Solution {
    public string MinWindow(string s, string t) {
            if (s.Length < t.Length) return "";
            Dictionary<char, int> tCount = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();
            foreach (char c in t)
                tCount[c] = tCount.ContainsKey(c) ? tCount[c] + 1 : 1;

            // track how much window have, how much needed
            // if tcount value of a key matches with windows, then have increases by one
            // if have matches need, found a valid solution. store its left index and length for result return
            // once need matched, try looking if any more options left with less length, so remove the left character from windows & reduce have to kickoff next computation

            int have = 0, need = tCount.Count;
            int l = 0, start = 0, length = int.MaxValue;
            int sL = s.Length;

            for(int r = 0; r < sL; r++)
            {
                char c = s[r];
                if(tCount.ContainsKey(c))
                {
                    window[c] = window.TryGetValue(c, out int v) ? v + 1 : 1;
                    if (tCount[c] == window[c])
                        have++;
                }

                while(have == need)
                {
                    if(r - l + 1 < length)
                    {
                        length = r - l + 1;
                        start = l;
                    }
                    char left = s[l];
                    if(window.ContainsKey(left))
                    {
                        window[left]--;
                        if (window[left] < tCount[left]) have--;
                    }
                    l++;
                }
            }
            return length == int.MaxValue ? "" : s.Substring(start, length);
    }
}
