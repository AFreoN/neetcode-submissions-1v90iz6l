public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length, id=0;
        int[] output = new int[n - k + 1];

        var priorityQueue = new PriorityQueue<(int v, int idx), int>();

        for(int i = 0; i < n; i++)
        {
            priorityQueue.Enqueue((nums[i], i), -nums[i]);

            if(i >= k - 1)  //If reached window size
            {
                while (priorityQueue.Peek().idx <= i - k) //if outside window
                    priorityQueue.Dequeue();

                output[id++] = priorityQueue.Peek().v;
            }
        }
        return output;
    }
}
