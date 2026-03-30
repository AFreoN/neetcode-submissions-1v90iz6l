public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);

        int length1 = nums1.Length, length2 = nums2.Length, total = length1 + length2;
        int left = 0, right = length1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int mid2 = ((total + 1) / 2) - mid;

            int left1 = mid == 0 ? int.MinValue : nums1[mid - 1];
            int right1 = mid == length1 ? int.MaxValue : nums1[mid];
            int left2 = mid2 == 0 ? int.MinValue: nums2[mid2 - 1];
            int right2 = mid2 == length2 ? int.MaxValue : nums2[mid2];

            if(left1 <= right2 && left2 <= right1)
            {
                if (total % 2 == 0) return ((double)Math.Max(left1, left2) + Math.Min(right1, right2)) / 2;
                return Math.Max(left1, left2);
            }

            if (left1 > right2)
                right = mid - 1;
            else 
                left = mid + 1;
        }
        return -1;
    }
}
