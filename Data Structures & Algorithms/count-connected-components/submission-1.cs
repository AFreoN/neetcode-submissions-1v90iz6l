public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<int>[] map = new List<int>[n];
        bool[] visit = new bool[n];

        for (int i = 0; i < n; i++) map[i] = new List<int>();
        foreach(var point in edges)
        {
            map[point[0]].Add(point[1]);
            map[point[1]].Add(point[0]);
        }

        int res = 0;

        for(int node = 0; node < n; node++)
        {
            if (visit[node]) continue;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            visit[node] = true;
            res++;

            while(queue.Count > 0)
            {
                var q = queue.Dequeue();
                foreach(int neig in map[q])
                {
                    if (!visit[neig])
                    {
                        visit[neig] = true;
                        queue.Enqueue(neig);
                    }
                }
            }
        }
        return res;
    }
}
