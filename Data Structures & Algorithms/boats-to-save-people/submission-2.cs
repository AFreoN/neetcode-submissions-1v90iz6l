public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int l = 0, r = people.Length - 1, boat = 0;
        Array.Sort(people);
        while(l <= r)
        {
            if(people[l] + people[r] <= limit)
            {
                l++;
                r--;
                boat++;
            }
            else
            {
                r--;
                boat++;
            }
        }
        return boat;
    }
}