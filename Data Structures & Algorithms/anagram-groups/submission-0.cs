public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();

        string[] hashValues = new string[strs.Length];

        int[,] freq = new int[strs.Length, 26];
        Dictionary<string, List<string>> finalDic = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            int[] h = new int[26];
            for (int j = 0; j < strs[i].Length; j++)    //j index used for each characters
            {
                h[strs[i][j] - 'a']++;
            }

            string hashValue = string.Join("#", h);

            if (finalDic.ContainsKey(hashValue))
                finalDic[hashValue].Add(strs[i]);
            else
                finalDic.Add(hashValue, new List<string> { strs[i] });
        }

        foreach (var item in finalDic)
        {
            result.Add(item.Value);
        }

        return result;
    }
}
