public class Solution {
    public int EvalRPN(string[] tokens) {
            Stack<int> s = new Stack<int>();
            char[] o = new char[4] {'+','-','*','/'};
            Dictionary<string, Func<int, int, int>> operations = new Dictionary<string, Func<int, int, int>>
            {
                { "+", (int a, int b) => a + b },
                { "-", (int a, int b) => a - b },
                { "*", (int a, int b) => a * b },
                { "/", (int a, int b) => a / b },
            };

            foreach(string c in tokens)
            {
                if(operations.ContainsKey(c) && s.Count >= 2)
                {
                    int t2 = s.Pop(), t1 = s.Pop();
                    s.Push(operations[c](t1, t2));
                }
                else
                    s.Push(int.Parse(c));
            }
            return s.Count >= 1 ? s.Pop() : 0;
    }
}
