public class Solution {
    public string ReorganizeString(string s) {
        int n = s.Length, maxIndex = 0, maxFrequency = 0;

        Span<int> fmap = stackalloc int[26];
        foreach (char c in s)
        {
            int id = c - 'a';
            if (++fmap[id] > maxFrequency)
            {
                maxFrequency = fmap[id];
                maxIndex = id;
            }
        }

        if (maxFrequency > (n + 1) / 2) return string.Empty;

        int writeIndex = 0;
        char[] res = new char[n];

        while (fmap[maxIndex] > 0)
        {
            res[writeIndex] = (char)(maxIndex + 'a');
            fmap[maxIndex]--;
            writeIndex += 2;
            if (writeIndex >= n) writeIndex = 1;
        }

        for(int i = 0; i < 26; i++)
        {
            while(fmap[i] > 0)
            {
                res[writeIndex] = (char)(i + 'a');
                fmap[i]--;
                writeIndex += 2;
                if(writeIndex >= n) writeIndex = 1;
            }
        }

        return new string(res);
    }
}