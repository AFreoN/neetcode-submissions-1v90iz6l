// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> res = new List<List<Pair>>();
        int n = pairs.Count;
        if(n == 0) return res; 

        res.Add([.. pairs]);

        for (int i = 1; i < n; i++)
        {
            int j = i - 1;
            int k = pairs[i].Key;

            while (j >= 0 && pairs[j].Key > k)
                (pairs[j], pairs[j + 1]) = (pairs[j + 1], pairs[j--]);

            res.Add([.. pairs]);
        }

        return res;                                                                                                    
    }
}
