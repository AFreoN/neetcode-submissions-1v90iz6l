// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {
        void MergeSortInterval(int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSortInterval(l, m);
                MergeSortInterval(m + 1, r);
                Merge(pairs, l, r, m);
            }
        }

        MergeSortInterval(0, pairs.Count - 1);
        return pairs;
    }

    void Merge(List<Pair> pairs, int l, int r, int m)
    {
        int n1 = m - l + 1, n2 = r - m;
        Pair[] L = new Pair[n1];
        Pair[] R = new Pair[n2];

        for (int p = 0; p < n1; p++)
            L[p] = pairs[l + p];

        for (int p = 0; p < n2; p++)
            R[p] = pairs[m + 1 + p];

        int k = l;
        l = 0;
        r = 0;
        while (l < n1 && r < n2)
        {
            if (L[l].Key <= R[r].Key) pairs[k++] = L[l++];
            else pairs[k++] = R[r++];
        }

        while(l < n1) pairs[k++] = L[l++];
        while (r < n2) pairs[k++] = R[r++];
    }
}
