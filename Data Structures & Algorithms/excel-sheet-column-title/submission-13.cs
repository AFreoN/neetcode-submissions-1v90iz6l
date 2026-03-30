public class Solution {
    public string ConvertToTitle(int columnNumber) {
            StringBuilder sb = new StringBuilder();
            int cycle = 1;

            while (columnNumber > 0)
            {
                columnNumber--;
                int rem = columnNumber % 26;
                sb.Insert(0, (char)(rem + 'A'));
                columnNumber /= 26;
            }

            return sb.ToString();
    }
}