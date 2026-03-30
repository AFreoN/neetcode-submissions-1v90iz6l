public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
            if (s[^1] == '1') return false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            int farthest = 0, n = s.Length;

            while (queue.Count > 0)
            {
                int i = queue.Dequeue();
                int start = Math.Max(i + minJump, farthest + 1);
                int end = Math.Min(i + maxJump, n - 1);
                for(int j = start; j <= end; j++)
                {
                    if (s[j] == '0')
                    {
                        if (j == n - 1) return true;
                        queue.Enqueue(j);
                    }
                }
                farthest = Math.Max(end, farthest);
            }

            return false;
    }
}