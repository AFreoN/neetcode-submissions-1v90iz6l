public class Solution {
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> deads = [.. deadends];
        if (deads.Contains("0000")) return -1;

        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("0000");
        visited.Add("0000");

        int res = 0;
        Span<char> span = stackalloc char[4];

        while (queue.Count > 0)
        {
            for (int i = queue.Count; i > 0; i--)
            {
                string cur = queue.Dequeue();

                if (cur == target) return res;

                for(int index = 0; index < 4; index++)
                    span[index] = cur[index];

                for (int j = 0; j < 4; j++)
                {
                    char c = span[j];

                    span[j] = (char)((c - '0' + 1) % 10 + '0');
                    string next = new string(span);
                    if (!visited.Contains(next) && !deads.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);
                    }

                    span[j] = (char)((c - '0' + 9) % 10 + '0');
                    next = new string(span);

                    if (!visited.Contains(next) && !deads.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);
                    }

                    span[j] = c;
                }

            }
            res++;
        }

        return -1;
    }
}