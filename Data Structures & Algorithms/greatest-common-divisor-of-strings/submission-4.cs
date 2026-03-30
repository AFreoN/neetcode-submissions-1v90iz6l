public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1) return string.Empty;

        int GCD(int a, int b)
        {
            while (b != 0)
                (a, b) = (b, a % b);
            return a;
        }

        return str1.Substring(0, GCD(str1.Length, str2.Length));
    }
}