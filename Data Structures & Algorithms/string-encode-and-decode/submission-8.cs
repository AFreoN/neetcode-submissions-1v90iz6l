public class Solution {

    public string Encode(IList<string> strs) {
            StringBuilder sb = new StringBuilder();
            foreach (string str in strs)
                sb.Append(str.Length).Append("¦").Append(str);

            return sb.ToString();
    }

    public List<string> Decode(string s) {
            List<string> res = new List<string>();
            int i = 0, n = s.Length;
            while(i < n)
            {
                int j = i;

                while (s[j] != '¦')
                    j++;

                int l = int.Parse(s.Substring(i, j - i));
                res.Add(s.Substring(j + 1, l));
                i = j + 1 + l;
            }
            return res;
    }
}
