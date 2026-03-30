public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int>[] map = new List<int>[numCourses];    //mapping of each course with dependency
        int[] indegs = new int[numCourses]; //amount of time this course is required for completion
        Queue<int> q = new Queue<int>();
        int[] result = new int[numCourses];
        int finished = 0;
        for (int i = 0; i < numCourses; i++) map[i] = new List<int>();
        foreach(var v in prerequisites) //mapping courses and frequency of course dependency
        {
            indegs[v[0]]++;
            map[v[1]].Add(v[0]);
        }
        for(int i = 0; i< numCourses; i++)  //if a course can be completed without dependency, we'll queue so that we'll get its depdency from that 
            if (indegs[i] == 0)
                q.Enqueue(i);

        while(q.Count > 0)
        {
            int node = q.Dequeue();
            result[finished++] = node;
            foreach (var v in map[node])
                if (--indegs[v] == 0)
                    q.Enqueue(v);
        }
        return finished != numCourses ? [] : result; 
    }
}
