public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            int n = strs.Length;
            string res = "";

            foreach(char c in strs[0])
            {
                for(int i = 1; i < n; i++)
                {
                    if (res.Length >= strs[i].Length || c != strs[i][res.Length])
                        return res;
                }
                res += c;
            }
            return res;
    }
}