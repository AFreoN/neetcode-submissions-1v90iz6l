public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        Dictionary<char, int> setA = new Dictionary<char, int>();
        Dictionary<char, int> setB = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){

            if(setA.ContainsKey(s[i]))
                setA[s[i]] += 1;
            else setA.Add(s[i], 1);

            if(setB.ContainsKey(t[i]))
                setB[t[i]] += 1;
            else setB.Add(t[i], 1);
        }

        if(setA.Count != setB.Count) return false;

        foreach (char c in setA.Keys)
        {
            if (setB.ContainsKey(c) && setB[c] == setA[c])
                continue;
            else
                return false;
        }

        return true;
    }
}
