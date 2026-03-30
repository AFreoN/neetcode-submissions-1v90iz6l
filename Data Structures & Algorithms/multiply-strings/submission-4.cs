public class Solution {
    public string Multiply(string num1, string num2) {
        int n1 = num1.Length, n2 = num2.Length, total = n1 + n2;
        Span<int> int1 = stackalloc int[n1];
        Span<int> int2 = stackalloc int[n2];
        for (int i = 0; i < n1; i++) int1[i] = num1[i] - '0';
        for (int i = 0; i < n2; i++) int2[i] = num2[i] - '0';

        Span<int> mult = stackalloc int[total];
        for(int i = n1 - 1; i >= 0; i--)
        {
            for(int j = n2 - 1; j >= 0; j--)
            {
                int id = j + i + 1;
                int v = mult[id] + (int1[i] * int2[j]);
                mult[id] = v % 10;
                mult[id - 1] += v / 10;
            }
        }

        int start = 0;
        while (start < total && mult[start] == 0) start++;
        StringBuilder sb = new StringBuilder();
        for(int i = start; i < total; i++)
            sb.Append(mult[i]);
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
