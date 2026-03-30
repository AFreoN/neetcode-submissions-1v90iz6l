public class Solution {
    public bool CheckValidString(string s) {
        int min = 0, max = 0;

        foreach(char c in s)
        {
            if (c == '(')
            {
                min++;
                max++;
            }
            else if (c == '*')
            {
                min--;
                max++;
            }
            else if (c == ')')
            {
                min--;
                max--;
            }

            if (max < 0) return false;
            if (min < 0) min = 0;
        }

        return min == 0;
    }
}
