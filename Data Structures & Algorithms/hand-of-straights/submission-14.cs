public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0) return false;

        SortedDictionary<int,int> freqMap = new SortedDictionary<int,int>();
        foreach (int v in hand)
        {
            if (!freqMap.ContainsKey(v)) freqMap[v] = 0;
            freqMap[v]++;
        }

        int k = hand.Length / groupSize;

        while(k-- > 0)
        {
            int start = freqMap.First().Key;
            if (--freqMap[start] == 0) freqMap.Remove(start);

            int end = start + groupSize;
            for (int i = start + 1; i < end; i++)
            {
                if (!freqMap.ContainsKey(i)) return false;
                if (--freqMap[i] == 0) freqMap.Remove(i);
            }
        }
        return true;
    }
}
