public class Solution {
    public List<List<string>> AccountsMerge(List<List<string>> accounts) {
        // 1. Union ids with same email
        int n = accounts.Count;
        Dictionary<string, int> emailToId = new Dictionary<string, int>();
        UnionFind uf = new UnionFind(n);

        for (int i = 0; i < n; i++)
        {
            var list = accounts[i];
            for (int j = 1; j < list.Count; j++)
            {
                string email = list[j];
                if (emailToId.TryGetValue(email, out int id))
                    uf.Union(id, i);
                else
                    emailToId.Add(email, i);
            }
        }

        // 2. group email with union ids
        Dictionary<int, List<string>> emailGroup = new Dictionary<int, List<string>>();
        foreach(var kp in emailToId)
        {
            string email = kp.Key;
            int root = uf.Find(kp.Value);
            emailGroup.TryAdd(root, new List<string>());
            emailGroup[root].Add(email);
        }

        // 3. add name and emails
        List<List<string>> res = new List<List<string>>();
        foreach (var kp in emailGroup)
        {
            int id = kp.Key;
            List<string> emails = kp.Value;
            List<string> name = new List<string>() { accounts[id][0] };
            name.AddRange(emails);
            res.Add(name);
        }

        return res;
    }
}

public class UnionFind
{
    int[] parent;
    int[] size;

    public UnionFind(int n)
    {
        parent = new int[n];
        size = new int[n];

        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
            size[i] = 1;
        }
    }

    public int Find(int n)
    {
        int x = parent[n];
        while(x != parent[x])
            x  = parent[x];
        return x;
    }

    public bool Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX == rootY) return false;

        if (size[rootX] < size[rootY])
        {
            parent[rootX] = rootY;
            size[rootY] += size[rootX];
        }
        else
        {
            parent[rootY] = rootX;
            size[rootX] += size[rootY];
        }

        return true;
    }
}