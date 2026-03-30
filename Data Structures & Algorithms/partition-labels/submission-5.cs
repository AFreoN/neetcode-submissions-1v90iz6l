public class Solution {
    public List<int> PartitionLabels(string s) {
        int n = s.Length;
        List<int> res = new List<int>();

        int[] last = new int[26];
        for(int i = 0; i < n; i++)
            last[s[i] - 'a'] = i;

        int index = 0;
        while (index < s.Length)
        {
            char curr = s[index];
            int start = index;
            int end = last[curr - 'a'];

            while (index <= end)
            {
                end = Math.Max(end, last[s[index] - 'a']);
                index++;
            }

            res.Add(index - start);
        }

        return res;
    }
}
