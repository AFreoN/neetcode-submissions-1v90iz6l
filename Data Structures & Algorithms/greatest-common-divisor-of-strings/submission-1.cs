public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1.Length < str2.Length) return GcdOfStrings(str2, str1);

        int n1 = str1.Length, n2 = str2.Length;

        bool IsDivisible(int e)
        {
            e++;
            if (n1 % e != 0) return false;
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i % e])
                    return false;
            }
            return true;
        }

        for (int i = str2.Length - 1; i >= 0; i--)
            if (IsDivisible(i) && n2 % (i+1) == 0)
                return str2.Substring(0, i + 1);

        return string.Empty;
    }
}