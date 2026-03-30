public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<int>[] map = new List<int>[n];
        Span<bool> visited = stackalloc bool[n];

        //Span list of nodes to store neighbours
        for (int i = 0; i < n; i++) map[i] = new List<int>();

        //Add neighbour connections
        foreach (int[] edge in edges)
        {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }

        //Loop through each connections, increase counter if not visited, then mark that and their neighbour as visted
        int res = 0;
        for(int node = 0; node < n; node++)
        {
            if (visited[node]) continue;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            res++;
            visited[node] = true;

            while (queue.Count > 0)
            {
                int curr = queue.Dequeue(); //get current node
                foreach (int neig in map[curr]) //loop through all the neighbour and mark as visited
                {
                    if (!visited[neig])
                    {
                        visited[neig] = true;
                        queue.Enqueue(neig);
                    }
                }
            }
        }

        return res;
    }
}
