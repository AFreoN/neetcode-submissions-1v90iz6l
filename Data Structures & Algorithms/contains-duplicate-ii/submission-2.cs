public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int l = 0, r = 1, n = nums.Length;
        HashSet<int> hash = new HashSet<int>(k);
        hash.Add(nums[l]);

        while(r < n)
        {
            if (hash.Contains(nums[r]))
                return true;

            hash.Add(nums[r]);
            r++;
            if(r - l > k)
            {
                hash.Remove(nums[l]);
                l++;
            }
        }
        return false;
    }
}