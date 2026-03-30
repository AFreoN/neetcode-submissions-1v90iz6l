public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1.Length < str2.Length) return GcdOfStrings(str2, str1);

        int n1 = str1.Length, n2 = str2.Length;

        bool IsDivisible(int e)
        {
            if (n1 % e != 0) return false;
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i % e])
                    return false;
            }
            return true;
        }

        int end = n2;
        while (end > 0)
        {
            if (n2 % end == 0 && IsDivisible(end))
                return str2.Substring(0, end);
            end--;
        }

        return string.Empty;
    }
}