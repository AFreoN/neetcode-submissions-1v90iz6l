public class Solution {
    const char DELIMITER = '|';

    // Encode using standard technique: Length + Delimiter + Content
    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs)
            sb.Append(str.Length).Append(DELIMITER).Append(str);

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0, n = s.Length;
        while (i < n)
        {
            int j = i;
            while (s[j] != DELIMITER)
                j++;

            int L = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, L));
            i = j + L + 1;
        }
        return result;
    }
}
