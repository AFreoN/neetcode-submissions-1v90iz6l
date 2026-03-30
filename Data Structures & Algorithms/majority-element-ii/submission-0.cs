public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int m = nums.Length / 3;

        int n1 = -1, n2 = -1;
        int c1 = 0, c2 = 0;

        // count two most frequent potential canditates
        foreach(int num in nums)
        {
            if (num == n1) c1++;
            else if(num == n2) c2++;
            else if(c1 == 0)
            {
                n1 = num;
                c1 = 1;
            }
            else if (c2 == 0)
            {
                n2 = num;
                c2 = 1;
            }
            else
            {
                c1--;
                c2--;
            }
        }
        
        c1 = c2 = 0;
        foreach (int num in nums)
        {
            if (num == n1) c1++;
            else if (num == n2) c2++;
        }

        List<int> res = new List<int>();
        if(c1 > m) res.Add(n1);
        if(c2 > m) res.Add(n2);

        return res;
    }
}