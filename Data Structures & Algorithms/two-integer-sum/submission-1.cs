public class Solution {
    public int[] TwoSum(int[] nums, int target) {
Dictionary<int, int> comp = new Dictionary<int, int>();
comp.Add(target - nums[0], 0);

for (int i = 1; i < nums.Length; i++)
{
    if (comp.ContainsKey(nums[i]))
        return new int[] { comp[nums[i]], i };
    else
        comp.Add(target - nums[i], i);
}

return null;
    }
}
