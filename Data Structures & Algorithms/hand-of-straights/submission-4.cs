public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        Array.Sort(hand);
        int n = hand.Length;
        bool[] used = new bool[n];
        int rem = n % groupSize;
        int k = n / groupSize + (rem > 0 ? 1 : 0);
        while (k-- > 0)
        {
            int size = 1, index = 0, curr = 0;

            // Find start value
            while (index < n && used[index])
                index++;

            used[index] = true;
            int start = hand[index];
            curr = start;

            while(++index < n && size < groupSize)
            {
                if (used[index] || curr == hand[index]) continue;
                if (curr + 1 != hand[index]) return false;
                used[index] = true;
                curr++;
                if (++size == groupSize) break;
            }

            int expectedSize = rem > 0 && k == 1 ? rem : groupSize;
            if (size != expectedSize) return false;
        }
        return true;
    }
}
