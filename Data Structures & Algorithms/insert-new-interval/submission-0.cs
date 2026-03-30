public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int n = intervals.Length, index = n;
        int[][] res = new int[n+1][];

        // 1. Find the find overlapping index using binary search
        int l = 0, r = n - 1;
        while(l <= r)
        {
            int m = l + (r - l) / 2;
            if (newInterval[0] <= intervals[m][1])
            {
                index = m;
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        // 2. Add all intervals before overlap
        for (int i = 0; i < index; i++)
            res[i] = intervals[i];

        // 3. Merge all overlapping
        int[] merged = newInterval;
        int resIndex = index;
        while(index < n && intervals[index][0] <= merged[1])
        {
            merged[0] = Math.Min(merged[0], intervals[index][0]);
            merged[1] = Math.Max(merged[1], intervals[index][1]);
            index++;
        }

        res[resIndex++] = merged;

        // 4. Add remaining intervals
        while(index < n)
        {
            res[resIndex++] = intervals[index++];
        }

        return res.Take(resIndex).ToArray();
    }
}
