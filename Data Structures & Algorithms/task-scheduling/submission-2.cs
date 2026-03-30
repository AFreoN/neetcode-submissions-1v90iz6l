public class Solution {
    public int LeastInterval(char[] tasks, int n) {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int mf = 1;
            foreach (char c in tasks)
            {
                if (map.ContainsKey(c))
                {
                    ++map[c];
                    if (map[c] > mf)
                        mf = map[c];
                }
                else map[c] = 1;
            }

            int fq = 0;
            foreach (var item in map)
            {
                if (item.Value == mf)
                    fq++;
            }

            return Math.Max(tasks.Length, (mf - 1) * (n + 1) + fq);
    }
}
