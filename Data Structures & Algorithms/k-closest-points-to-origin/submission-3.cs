public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], int>();

        foreach(var point in points)
            pq.Enqueue(point, point[0] * point[0] + point[1] * point[1]);

        int[][] o = new int[k][];
        for (int i = 0; i < k; i++)
            o[i] = pq.Dequeue();

        return o;
    }
}
