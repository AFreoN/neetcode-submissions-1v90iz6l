public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int l = 0, r = 1, res = 1;
        char prev = ' ';

        while (r < arr.Length)
        {
            if (arr[r - 1] > arr[r] && prev != '>')
            {
                res = Math.Max(res, r - l + 1);
                r++;
                prev = '>';
            }
            else if (arr[r - 1] < arr[r] && prev != '<')
            {
                res = Math.Max(res, r - l + 1);
                r++;
                prev = '<';
            }
            else
            {
                r = (arr[r - 1] == arr[r]) ? r + 1 : r;
                l = r - 1;
                prev = ' ';
            }
        }

        return res;
    }
}