public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int n = intervals.Length, res = 0;
        int end = intervals[0][1];

        for(int i = 1; i < n; i++)
        {
            if (intervals[i][0] < end) res++;
            else end = intervals[i][1];
        }

        return res;
    }
}
