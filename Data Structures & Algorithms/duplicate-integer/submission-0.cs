public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> scanned = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(scanned.Contains(nums[i]))
                return true;
            else
                scanned.Add(nums[i]);
        }

        return false;
    }
}