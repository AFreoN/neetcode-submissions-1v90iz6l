public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], int>();

        foreach(var point in points)
        {
            int x = point[0];
            int y = point[1];
            int m = x * x + y * y;
            pq.Enqueue(point, -m);
            if(pq.Count > k)
                pq.Dequeue();
        }
        int[][] o = new int[k][];
        for (int i = 0; i < k; i++)
            o[i] = pq.Dequeue();

        return o;
    }
}
