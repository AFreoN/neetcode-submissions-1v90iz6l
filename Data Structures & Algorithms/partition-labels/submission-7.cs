public class Solution {
    public List<int> PartitionLabels(string s) {
        int n = s.Length;
        List<int> res = new List<int>();

        Span<int> last = stackalloc int[26];
        for(int i = 0; i < n; i++)
            last[s[i] - 'a'] = i;

        int index = 0;
        while (index < s.Length)
        {
            int start = index;
            int end = last[s[index] - 'a'];

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
