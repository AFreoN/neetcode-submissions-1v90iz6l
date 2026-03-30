public class Solution {
    public string ConvertToTitle(int columnNumber) {
        List<char> res = new List<char>();

        while (columnNumber > 0)
        {
            columnNumber = Math.DivRem(--columnNumber, 26, out int rem);
            res.Add((char)(65 + rem));
        }
        res.Reverse();
        return new string(res.ToArray());
    }
}