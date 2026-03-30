public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        bool[] visited = new bool[numCourses];
        for (int i = 0; i < numCourses; i++)
            map[i] = new List<int>();
        
        foreach(var v in prerequisites)
            map[v[0]].Add(v[1]);

        bool dfs(int course)
        {
            if(visited[course]) return false;
            if(map[course].Count == 0) return true;
            visited[course] = true;
            foreach(int n in map[course])
                if(!dfs(n)) return false;
            visited[course] = false;
            map[course].Clear();
            return true;
        }

        for(int i = 0; i < numCourses; i++)
            if(!dfs(i)) return false;
        
        return true;
    }
}
