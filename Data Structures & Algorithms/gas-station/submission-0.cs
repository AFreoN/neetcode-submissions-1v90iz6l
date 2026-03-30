public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
                    int n = gas.Length, sum = 0, total = 0, startIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int fuelUsed = gas[i] - cost[i];
                total += fuelUsed;
                sum += fuelUsed;
                if (sum < 0)
                {
                    sum = 0;
                    startIndex = i + 1;
                }
            }

            return total >= 0 ? startIndex : -1;
    }
}
