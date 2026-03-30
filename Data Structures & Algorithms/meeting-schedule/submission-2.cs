/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if(intervals.Count == 0) return true;
        intervals.Sort((a,b) => a.start.CompareTo(b.start));
        int min = intervals[0].start, max = intervals[0].end;
        for (int i = 1; i < intervals.Count; i++)
        {
            int start = intervals[i].start;
            if (min <= start && start < max) return false;
            int end = intervals[i].end;
            if (start < min) min = start;
            if(end > max) max = end;
        }
        return true;
    }
}
