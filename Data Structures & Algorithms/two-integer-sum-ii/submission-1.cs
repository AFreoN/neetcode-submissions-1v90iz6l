public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int i = 0; i < numbers.Length; i++)
{
    int dif = target - numbers[i]; //complement

    int complementIndex = Array.FindIndex(numbers, n => n == dif);

    if(complementIndex != -1 && complementIndex != i)
    {
        return new int[] { i + 1, complementIndex + 1  };
    }
}

return null;
    }
}
