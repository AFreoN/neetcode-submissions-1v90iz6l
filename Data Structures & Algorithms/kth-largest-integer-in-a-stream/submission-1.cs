public class KthLargest {
    PriorityQueue<int,int> q = new PriorityQueue<int,int>();
    int k;
    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        foreach(int v in nums)
        {
            q.Enqueue(v, v);
            if(q.Count > k)
                q.Dequeue();
        }
    }

    public int Add(int val)
    {
        q.Enqueue(val, val);
        if(q.Count > k)
            q.Dequeue();

        return q.Peek();
    }
}
