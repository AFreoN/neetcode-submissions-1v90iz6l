public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        int[] size = new int[n + 1];

        int Find(int x)
        {
            if (x != parent[x])
                parent[x] = Find(parent[x]);

            return parent[x];
        }

        bool Union(int n1, int n2)
        {
            int root1 = Find(n1);
            int root2 = Find(n2);

            if (root1 == root2) return false;

            if (size[root1] < size[root2])
            {
                parent[root1] = root2;
                size[root2] += size[root1];
            }
            else
            {
                parent[root2] = root1;
                size[root1] += size[root2];
            }
            return true;
        }

        for (int i = 1; i <= n; i++)
        {
            parent[i] = i;
            size[i] = 1;
        }

        foreach (var v in edges)
            if (!Union(v[0], v[1]))
                return v;

        return [];
    }
}
