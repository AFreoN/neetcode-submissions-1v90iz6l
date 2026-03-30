public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int l = 0, r = 1, n = nums.Length;
        HashSet<int> window = new HashSet<int>();
        window.Add(nums[0]);

        while(r < n)
        {
            if (!window.Add(nums[r++]))
                return true;

            if(r - l > k)
                window.Remove(nums[l++]);
        }
        return false;
    }
}