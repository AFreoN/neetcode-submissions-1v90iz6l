public class Solution {
    public int FindKthLargest(int[] nums, int k) {
            var p = new PriorityQueue<int, int>();
            foreach (var v in nums)
            {
                p.Enqueue(v, v);
                if (p.Count > k)
                    p.Dequeue();
            }
            return p.Dequeue();
    }
}
