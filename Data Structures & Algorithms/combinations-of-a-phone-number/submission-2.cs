public class Solution {
    readonly Dictionary<char, string> map = new Dictionary<char, string>
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };
    public List<string> LetterCombinations(string digits) {
        if(digits.Length == 0) return new List<string>();
        List<string> res = new List<string>();

        void DFS(int idx, string curr)
        {
            if(curr.Length == digits.Length)
            {
                res.Add(curr);
                return;
            }

            string letters = map[digits[idx]];
            foreach(char c in letters)
                DFS(idx + 1, curr + c);
        }
        DFS(0, "");
        return res;
    }
}
