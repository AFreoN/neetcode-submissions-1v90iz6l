public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        for(int i = n / 2 - 1; i >= 0; i--)
            Heapify(nums, n, i);

        for(int i = n - 1; i > 0; i--)
        {
            (nums[0], nums[i]) = (nums[i], nums[0]);
            Heapify(nums, i, 0);
        }
        return nums;
    }

    void Heapify(int[] arr, int end, int index)
    {
        int largest = index;
        int l = index * 2 + 1;
        int r = index * 2 + 2;

        if(l < end && arr[l] > arr[largest])
            largest = l;

        if (r < end && arr[r] > arr[largest])
            largest = r;

        if(largest != index)
        {
            (arr[largest], arr[index]) = (arr[index], arr[largest]);
            Heapify(arr, end, largest);
        }
    }
}