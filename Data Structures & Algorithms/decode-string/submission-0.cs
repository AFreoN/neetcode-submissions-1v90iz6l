public class Solution {
    public string DecodeString(string s) {
        StringBuilder sb = new StringBuilder();
        int i = 0, n = s.Length;

        int GetCount(ref int index)
        {
            int count = 0;
            while (index < n && char.IsDigit(s[index]))
            {
                count = count * 10 + (s[index] - '0');
                index++;
            }
            return count;
        }

        while(i < n)
        {
            if (char.IsDigit(s[i]) == false)
            {
                sb.Append(s[i]);
                i++;
            }
            else
            {
                int c = GetCount(ref i);
                int brace = 1;
                i++;
                int start = i;

                while (i < n && brace > 0)
                {
                    if (s[i] == '[')
                        brace++;                        
                    else if (s[i] == ']')
                        brace--;

                    i++;
                }

                string innerDecoded = DecodeString(s.Substring(start, i - start - 1));
                while(--c >= 0)
                    sb.Append(innerDecoded);
            }
        }

        return sb.ToString();
    }
}