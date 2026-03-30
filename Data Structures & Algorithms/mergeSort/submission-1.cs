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

        int i = 0,j = 0, k = l;
        while (i < n1 && j < n2)
        {
            if (L[i].Key <= R[j].Key) pairs[k++] = L[i++];
            else pairs[k++] = R[j++];
        }

        while(i < n1) pairs[k++] = L[i++];
        while (j < n2) pairs[k++] = R[j++];
    }
}
