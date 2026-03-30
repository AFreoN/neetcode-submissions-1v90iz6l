public class Solution {
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> deads = [.. deadends];
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("0000");

        int res = 0;

        while (queue.Count > 0)
        {
            for (int i = queue.Count; i > 0; i--)
            {
                string cur = queue.Dequeue();
                if (visited.Contains(cur) || deads.Contains(cur)) continue;
                if (cur == target) return res;

                visited.Add(cur);

                for (int j = 0; j < 4; j++)
                {
                    char[] s = cur.ToCharArray();
                    int v = cur[j] - '0';
                    int forward = (v + 1) % 10;
                    int backward = (v + 9) % 10;

                    s[j] = (char)(forward + '0');
                    queue.Enqueue(new string(s));

                    s[j] = (char)(backward + '0');
                    queue.Enqueue(new string(s));
                }

            }
            res++;
        }

        return -1;
    }
}