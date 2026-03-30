public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        SortedDictionary<int,int> freqMap = new SortedDictionary<int,int>();
        foreach (int v in hand)
        {
            if (!freqMap.ContainsKey(v)) freqMap[v] = 0;
            freqMap[v]++;
        }

        int rem = hand.Length % groupSize;
        if(rem != 0) return false;
        int k = (hand.Length + groupSize - 1) / groupSize;

        while(k-- > 0)
        {
            int start = freqMap.First().Key;
            if (--freqMap[start] == 0) freqMap.Remove(start);

            int end = start + (k == 1 && rem != 0? rem : groupSize);
            for (int i = start + 1; i < end; i++)
            {
                if (!freqMap.ContainsKey(i)) return false;
                if (--freqMap[i] == 0) freqMap.Remove(i);
            }
        }
        return true;
    }
}
