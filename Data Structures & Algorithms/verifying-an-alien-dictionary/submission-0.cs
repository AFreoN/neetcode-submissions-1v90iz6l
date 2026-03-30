public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int i = 0; i < order.Length; i++)
            map[order[i]] = i;

        for (int i = 1; i < words.Length; i++)
        {
            string w1 = words[i - 1];
            string w2 = words[i];

            for (int j = 0; j < w1.Length; j++)
            {
                if (j == w2.Length) return false;

                if (w1[j] != w2[j])
                {
                    if (map[w1[j]] > map[w2[j]]) return false;
                    break;
                }
            }
        }

        return true;
    }
}