public class Solution {
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> deads = [.. deadends];
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();

        if (deadends.Contains("0000")) return -1;
        queue.Enqueue("0000");

        int res = 0;

        while (queue.Count > 0)
        {
            for (int i = queue.Count; i > 0; i--)
            {
                string cur = queue.Dequeue();

                if (cur == target) return res;

                for (int j = 0; j < 4; j++)
                {
                    string next = cur.Substring(0, j) + ((cur[j] - '0' + 1) % 10) + cur.Substring(j + 1);

                    if (!visited.Contains(next) && !deads.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);
                    }

                    next = cur.Substring(0, j) + ((cur[j] - '0' + 9) % 10) + cur.Substring(j + 1);

                    if (!visited.Contains(next) && !deads.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);
                    }
                }

            }
            res++;
        }

        return -1;
    }
}