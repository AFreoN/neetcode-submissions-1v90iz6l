public class Solution {
    public string Multiply(string num1, string num2) {
            long n1 = 0;
            foreach(char c in num1)
            {
                int v = c - '0';
                n1 = n1 * 10 + v;
            }

            long n2 = 0;
            foreach (char c in num2)
            {
                int v = c - '0';
                n2 = n2 * 10 + v;
            }
            long res = n1 * n2;
            return res.ToString();
    }
}
