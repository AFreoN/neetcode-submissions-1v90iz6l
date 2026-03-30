public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] hashSet = new char[26];
            foreach(char c in s)
                hashSet[c - 'a']++;

            string hashString = new string(hashSet);

            if (dic.ContainsKey(hashString))
                dic[hashString].Add(s);
            else
                dic.Add(hashString, new List<string> { s });
        }

        return new List<List<string>>(dic.Values);
    }
}
