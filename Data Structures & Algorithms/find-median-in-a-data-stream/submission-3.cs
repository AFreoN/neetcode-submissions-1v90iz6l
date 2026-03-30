public class MedianFinder {
    PriorityQueue<int,int> leftMaxHeap, rightMinHeap;
    public MedianFinder() {
        leftMaxHeap = new PriorityQueue<int,int>();
        rightMinHeap = new PriorityQueue<int,int>();
    }
    
    public void AddNum(int num) {
        leftMaxHeap.Enqueue(num, -num);
        int l = leftMaxHeap.Dequeue();
        rightMinHeap.Enqueue(l, l);

        if (rightMinHeap.Count > leftMaxHeap.Count)
        {
            int r = rightMinHeap.Dequeue();
            leftMaxHeap.Enqueue(r, -r);
        }
    }
    
    public double FindMedian() {
        return leftMaxHeap.Count != rightMinHeap.Count ? leftMaxHeap.Peek() :
            (leftMaxHeap.Peek() + rightMinHeap.Peek()) / 2d;
    }
}
