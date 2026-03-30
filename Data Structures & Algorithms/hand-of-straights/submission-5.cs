public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        Array.Sort(hand);   //sort the array for easy picking
        int n = hand.Length;
        int rem = n % groupSize;
        int k = (n + groupSize - 1) / groupSize;    //calculate window count

        bool[] used = new bool[n];

        while (k-- > 0) // perform lineup for each window
        {
            int size = 1, index = 0, curr = 0;

            // Find start value
            while (index < n && used[index])
                index++;

            used[index] = true;
            int start = hand[index];
            curr = start;

            // Form window
            while(++index < n && size < groupSize)
            {
                if (used[index] || curr == hand[index]) continue;
                if (curr + 1 != hand[index]) return false;
                used[index] = true;
                curr++;
                size++;
            }

            // check fail condition
            int expectedSize = k == 1 && rem > 0 ? rem : groupSize;
            if (size != expectedSize) return false;
        }
        return true;
    }
}
