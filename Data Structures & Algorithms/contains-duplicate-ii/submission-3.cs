public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int l = 0, r = 1, n = nums.Length;
        HashSet<int> window = new HashSet<int>();
        window.Add(nums[0]);

        while(r < n)
        {
            if (window.Contains(nums[r]))
                return true;

            window.Add(nums[r++]);
            if(r - l > k)
                window.Remove(nums[l++]);
        }
        return false;
    }
}