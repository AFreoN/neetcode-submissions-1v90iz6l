public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        void Heapify(int end, int index)
        {
            int largest = index;
            int l = index * 2 + 1;
            int r = index * 2 + 2;

            if (l < end && nums[l] > nums[largest])
                largest = l;

            if (r < end && nums[r] > nums[largest])
                largest = r;

            if (largest != index)
            {
                (nums[largest], nums[index]) = (nums[index], nums[largest]);
                Heapify(end, largest);
            }
        }

        for(int i = n / 2 - 1; i >= 0; i--)
            Heapify(n, i);

        for(int i = n - 1; i >= 0; i--)
        {
            (nums[0], nums[i]) = (nums[i], nums[0]);
            Heapify(i, 0);
        }
        return nums;
    }
}