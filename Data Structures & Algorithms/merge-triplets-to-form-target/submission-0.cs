public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool x = false, y = false, z = false;

        foreach (int[] triplet in triplets)
        {
            if (triplet[0] > target[0] || triplet[1] > target[1] || triplet[2] > target[2])
                continue;

            if(!x) x = triplet[0] == target[0];
            if(!y) y = triplet[1] == target[1];
            if(!z) z = triplet[2] == target[2];

            if (x && y && z) return true;
        }

        return x && y && z;
    }
}
