public class Solution {
    public List<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        if (queries.Length == 0) return new List<bool>();

        HashSet<int>[] map = new HashSet<int>[numCourses];

        // Initialize hashset
        for(int i = 0; i < numCourses; i++)
            map[i] = new HashSet<int>();

        // Map prerequisites for each course
        foreach (var v in prerequisites)
            map[v[0]].Add(v[1]);

        // Loop through each queries
        List<bool> res = new List<bool>();

        foreach (var query in queries)
        {
            int target = query[1];
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();

            visited.Add(query[0]);
            queue.Enqueue(query[0]);

            bool contains = false;
            while (queue.Count > 0)
            {
                int i = queue.Dequeue();

                if (map[i].Contains(target))
                {
                    contains = true;
                    break;
                }
                foreach (var v in map[i])
                    if(visited.Add(v))
                        queue.Enqueue(v);
            }
            res.Add(contains);
        }

        return res;
    }
}