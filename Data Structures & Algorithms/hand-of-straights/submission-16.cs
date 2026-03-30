public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0) return false;

        SortedDictionary<int,int> freqMap = new SortedDictionary<int,int>();
        foreach (int v in hand)
        {
            if (!freqMap.ContainsKey(v)) freqMap[v] = 0;
            freqMap[v]++;
        }

            List<int> values = new List<int>(freqMap.Keys);
            foreach (int v in values)
            {
                int count = freqMap[v];
                if(count <= 0) continue;

                int end = v + groupSize;
                for(int i = v + 1; i < end; i++)
                {
                    if (!freqMap.ContainsKey(i) || freqMap[i] < count) return false;
                    freqMap[i] -= count;
                }
            }
        return true;
    }
}
