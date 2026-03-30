public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int[] sortedQueries = queries.OrderBy(q => q).ToArray();
        Dictionary<int,int> map = new Dictionary<int,int>();
        PriorityQueue<(int size, int end), int> minHeap = new PriorityQueue<(int, int), int>();
        int i = 0, n = intervals.Length;

        foreach(int q in sortedQueries)
        {
            while(i < n && intervals[i][0] <= q)
            {
                int r = intervals[i][1];
                int d = r - intervals[i][0] + 1;
                minHeap.Enqueue((d, r), d);
                i++;
            }

            while (minHeap.Count > 0 && minHeap.Peek().end < q)
                minHeap.Dequeue();

            map[q] = minHeap.Count == 0 ? -1 : minHeap.Peek().size;
        }

        int[] result = new int[queries.Length];
        for (int j = 0; j < queries.Length; j++)
            result[j] = map[queries[j]];

        return result;
    }
}
