public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    void MergeSort(int[] arr, int l, int r)
    {
        if(l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, r, m);
        }
    }

    void Merge(int[] arr, int l, int r, int m)
    {
        int[] L = arr[l..(m + 1)];
        int[] R = arr[(m + 1)..(r + 1)];

        int n1 = L.Length, n2 = R.Length;
        int i = 0, j = 0, k = l;
        while(i < n1 && j < n2)
        {
            if (L[i] <= R[j]) arr[k++] = L[i++];
            else arr[k++] = R[j++];
        }
        while (i < n1) arr[k++] = L[i++];
        while(j < n2) arr[k++]= R[j++];
    }
}