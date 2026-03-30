public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Edge case
        if (nums.Length <= k) return nums;

        //number value, frequency
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int[] result = new int[k];

        foreach (var v in nums)
        {
            if (freq.ContainsKey(v))
                freq[v]++;
            else 
                freq.Add(v, 1);
        }

        var ordered = freq.OrderByDescending(d => d.Value);

        int i = 0;
        foreach (var item in ordered)
        {
            result[i] = item.Key;
            i++;

            if(i == k) break;
        }


        return result;
    }
}
