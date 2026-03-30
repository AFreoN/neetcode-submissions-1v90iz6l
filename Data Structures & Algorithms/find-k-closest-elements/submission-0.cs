public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int l = 0, r = arr.Length - k;
        while(l < r)
        {
            int m = (r + l) / 2;
            if (x - arr[m] > arr[m + k] - x) l = m + 1;
            else r = m;
        }
        return arr.Skip(l).Take(k).ToList();
    }
}