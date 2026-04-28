public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
            List<int>[] map = new List<int>[numCourses];
            bool[] visited = new bool[numCourses];

            // initialize empty list for each course
            for (int i = 0; i < numCourses; i++)
                map[i] = new List<int>();

            // build prerequisites map for each course
            foreach (var v in prerequisites)
                map[v[0]].Add(v[1]);

            bool dfs(int course)
            {
                if (visited[course]) return false;  //detected cycle
                if (map[course].Count == 0) return true; // no prerequisited left

                visited[course] = true; // mark this course as visited

                // recursively check if all prerequisite courses can be completed
                foreach (var prerequisite in map[course])
                    if (!dfs(prerequisite))
                        return false;

                // backtrack
                visited[course] = false;    
                map[course].Clear();

                return true;
            }

            // go through each courses and detect if there is cycle
            for (int i = 0; i < numCourses; i++)
                if (!dfs(i))
                    return false;

            return true;
    }
}
