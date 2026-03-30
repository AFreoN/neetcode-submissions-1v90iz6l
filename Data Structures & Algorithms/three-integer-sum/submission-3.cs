public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // 1. Sort the array
Array.Sort(nums);

// 2. Remove duplicates
List<List<int>> result = new List<List<int>>();

// 3. For each num, do two sum using two pointer
for (int i = 0; i < nums.Length - 2; i++)
{
    if (i > 0 && nums[i - 1] == nums[i]) continue;

    int left = i + 1;
    int right = nums.Length - 1;

    while(left < right)
    {
        int sum = nums[i] + nums[left] + nums[right];

        if (sum == 0)
        {
            result.Add(new List<int>() { nums[i], nums[left], nums[right] });
            left++;
            right--;

            while (left < right && nums[left] == nums[left - 1])
                left++;

            while (left < right && nums[right] == nums[right + 1])
                right--;
        }
        else if (sum < 0) left++;
        else if(sum > 0) right--;
    }
}

return result;
    }
}
