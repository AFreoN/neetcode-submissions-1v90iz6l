public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int n = strs.Length;
        string res = "";
        int counter = 0;
        while(counter < strs[0].Length)
        {
            char t = strs[0][counter];
            for(int i = 1; i < n; i++)
            {
                if(counter >= strs[i].Length || t != strs[i][counter])
                    return res;
            }
            counter++;
            res += t;
        }
        return res;
    }
}