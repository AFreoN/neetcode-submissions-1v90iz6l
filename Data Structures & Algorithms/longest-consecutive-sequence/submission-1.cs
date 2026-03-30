public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> map = new HashSet<int>(nums);
        int r = 0;
        foreach(int v in map)
        {
            if(!map.Contains(v-1))
            {
                int L = 1;
                while (map.Contains(v + L)) L++;
                r = Math.Max(r, L);
            }
        }
        return r;
    }
}
