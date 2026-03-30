public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(prerequisites == null || prerequisites.Length == 0) return true;
        int ROWS = prerequisites.Length, COLS = prerequisites[0].Length;
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < numCourses; i++)
            map[i] = new List<int>();
        
        foreach(var v in prerequisites)
            map[v[0]].Add(v[1]);

        bool dfs(int course)
        {
            if(visited.Contains(course)) return false;
            if(map[course].Count == 0) return true;
            visited.Add(course);
            foreach(int n in map[course])
                if(!dfs(n)) return false;
            visited.Remove(course);
            map[course].Clear();
            return true;
        }

        for(int i = 0; i < numCourses; i++)
            if(!dfs(i)) return false;
        
        return true;
    }
}
