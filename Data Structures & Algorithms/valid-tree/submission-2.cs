public class Solution {
    public bool ValidTree(int n, int[][] edges) {
            List<int>[] map = new List<int>[n];
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++) map[i] = new List<int>();
            foreach (var v in edges)
            {
                map[v[0]].Add(v[1]);
                map[v[1]].Add(v[0]);
            }
            Queue<(int node, int parent)> q = new Queue<(int node, int parent)> ();
            q.Enqueue((0, -1));
            visited[0] = true;
            int k = 1;
            while(q.Count > 0)
            {
                var (node, parent) = q.Dequeue();
                foreach(int i in map[node])
                {
                    if(i == parent) continue;
                    if(visited[i]) return false;    //detected cycle
                    k++;
                    visited[i] = true;
                    q.Enqueue((i, node));
                }
            }
            return k == n;
    }
}
