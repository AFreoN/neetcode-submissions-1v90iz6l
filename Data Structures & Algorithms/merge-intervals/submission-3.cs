public class Solution {
    public int[][] Merge(int[][] intervals) {
        var comparer = Comparer<int[]>.Create((int[] a, int[] b) => a[0] - b[0]);
        Array.Sort(intervals, comparer);

        int n = intervals.Length, index = 1, resIndex = 0;
        int[][] res = new int[n][];
        res[0] = intervals[0];

        while (index < n)
        {
            if (intervals[index][0] <= res[resIndex][1])
            {
                res[resIndex][0] = Math.Min(res[resIndex][0], intervals[index][0]);
                res[resIndex][1] = Math.Max(res[resIndex][1], intervals[index][1]);
            }
            else
            {
                res[++resIndex] = intervals[index];
            }
            index++;
        }

        Array.Resize(ref res, resIndex + 1);
        return res;
    }
}
