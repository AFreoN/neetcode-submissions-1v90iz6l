public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1 = word1.Length, n2 = word2.Length, start = 0;
        string result = "";
        while(start < n1 && start < n2)
        {
            result += word1[start];
            result += word2[start];
            start++;
        }

        if (n1 > n2)
            result += word1.Substring(start, n1 - start);
        else if(n1 < n2)
            result += word2.Substring(start, n2 - start);
        return result;
    }
}