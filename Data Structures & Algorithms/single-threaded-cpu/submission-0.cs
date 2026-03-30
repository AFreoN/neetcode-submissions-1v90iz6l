public class Solution {
    public int[] GetOrder(int[][] tasks) {
        int n = tasks.Length;
        int[] res = new int[n];
        PriorityQueue<(int enqueueTime, int processingTime, int idx), int> heap = new PriorityQueue<(int enqueueTime, int processingTime, int idx), int>();

        for (int i = 0; i < n; i++)
            heap.Enqueue((tasks[i][0], tasks[i][1], i), tasks[i][0]);

        int timePassed = heap.Peek().enqueueTime, index = 0;

        PriorityQueue<(int eqTime, int pTime, int idx), (int value, int index)> availableTasksHeap = new PriorityQueue<(int eqTime, int pTime, int idx), (int value, int index)>();
        while (heap.Count > 0 || availableTasksHeap.Count > 0)
        {
            // add all available tasks now
            while(heap.Count > 0 && heap.Peek().enqueueTime <= timePassed)
            {
                var v = heap.Dequeue();
                availableTasksHeap.Enqueue(v, (v.processingTime, v.idx));
            }

            if(heap.Count > 0 && availableTasksHeap.Count == 0)
            {
                timePassed = heap.Peek().enqueueTime;
                continue;
            }

            var curr = availableTasksHeap.Dequeue();
            res[index++] = curr.idx;
            timePassed += curr.pTime;
        }

        return res;
    }
}