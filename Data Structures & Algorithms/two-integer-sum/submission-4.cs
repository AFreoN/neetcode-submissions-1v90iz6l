public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            int tIndex = Array.FindIndex(nums, num => num == target - nums[i]);   //Find if there is any complement

            if(tIndex != -1 && tIndex != i) //If complement not found or not this index 
                return tIndex < i ? new int[2] { tIndex, i } : new int[2] { i, tIndex };
        }

        return null;
    }
}
