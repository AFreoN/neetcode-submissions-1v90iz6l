public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == k) return nums;

        int[] result = new int[k];

        // Build frequency map
        Dictionary<int, int> freqMap = new();
        foreach (int v in nums)
            freqMap[v] = freqMap.TryGetValue(v, out int o) ? o + 1 : 1;

        // build bucket for each value and store its key
        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach(var item in freqMap)
        {
            if (bucket[item.Value] == null)
                bucket[item.Value] = new List<int>();

            bucket[item.Value].Add(item.Key);
        }

        //get top k elements
        int index = 0;
        for(int i = bucket.Length - 1; i >= 0 && index < k; i--)
        {
            //if no bucket for this value, continue
            if (bucket[i] == null) continue;

            foreach(int key in bucket[i])
            {
                result[index++] = key;
                if(index == k) break;
            }
        }

        return result;
    }
}
