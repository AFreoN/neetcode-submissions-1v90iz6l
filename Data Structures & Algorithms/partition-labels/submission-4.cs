public class Solution {
    public List<int> PartitionLabels(string s) {
            List<int> res = new List<int>();

            Dictionary<char, int> lastIndexMap = new Dictionary<char, int>();
            foreach (char c in s)
                if (!lastIndexMap.ContainsKey(c))
                    lastIndexMap[c] = s.LastIndexOf(c);

            int i = 0;
            while (i < s.Length)
            {
                char curr = s[i];
                int start = i;
                int end = lastIndexMap[curr];

                while (i <= end)
                {
                    end = Math.Max(end, lastIndexMap[s[i]]);
                    i++;
                }

                res.Add(i - start);
            }

            return res;
    }
}
