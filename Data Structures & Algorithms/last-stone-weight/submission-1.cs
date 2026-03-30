public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();
        foreach (int v in stones)
            pq.Enqueue(v, -v);

        while(pq.Count > 1)
        {
            int w = pq.Dequeue() - pq.Dequeue();
            if (w != 0)
                pq.Enqueue(w, -w);
        }
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}
