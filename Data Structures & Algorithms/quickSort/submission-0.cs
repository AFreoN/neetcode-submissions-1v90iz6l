// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        void QuickSortHelper(int s, int e)
        {
            if (e - s <= 0) return;

            Pair endPair = pairs[e];
            int left = s;

            for (int i = s; i < e; i++)
                if (pairs[i].Key < endPair.Key)
                    (pairs[left], pairs[i]) = (pairs[i], pairs[left++]);

            pairs[e] = pairs[left];
            pairs[left] = endPair;

            QuickSortHelper(s, left - 1);
            QuickSortHelper(left + 1, e);
        }

        QuickSortHelper(0, pairs.Count- 1);
        return pairs;
    }
}
