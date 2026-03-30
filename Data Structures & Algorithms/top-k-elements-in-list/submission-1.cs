public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Edge case
        if (nums.Length <= k) return nums;

        //number value, frequency
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int[] result = new int[k];

        foreach (var v in nums)
        {
            if(!freq.ContainsKey(v))
                freq[v] = 0;

            freq[v]++;
        }

        //Create a bucket that stores value from 1 all the way to max length (n + 1)
        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (var item in freq)
        {
            int value = item.Value;

            if (bucket[value] == null)
                bucket[value] = new List<int>();

            bucket[value].Add(item.Key);
        }

        // Get the frequest top k element using bucket by looping from reverse
        int index = 0;

        for(int i = bucket.Length - 1; i >= 0 && index < k; i--)
        {
            if (bucket[i] == null)  //If no bucket, continue to next low value
                continue;

            foreach (var item in bucket[i])
            {
                result[index++] = item;
                if(index == k) break;
            }
        }

        return result;
    }
}
