public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1) return false;
        List<int>[] map = new List<int>[n];
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < n; i++) map[i] = new List<int>();
        foreach (var v in edges)
        {
            map[v[0]].Add(v[1]);
            map[v[1]].Add(v[0]);
        }
        Queue<(int node, int parent)> q = new Queue<(int node, int parent)> ();
        q.Enqueue((0, -1));
        visited.Add(0);
        while(q.Count > 0)
        {
            var (node, parent) = q.Dequeue();
            foreach(int neighbor in map[node])
            {
                if(neighbor == parent) continue;
                if(visited.Contains(neighbor)) return false;    //detected cycle
                visited.Add(neighbor);
                q.Enqueue((neighbor, node));
            }
        }
        return visited.Count == n;
    }
}
