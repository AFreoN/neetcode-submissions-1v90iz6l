public class Solution {
    public int EvalRPN(string[] tokens) {
            Stack<int> s = new Stack<int>();
            int r = 0, t1, t2;
            Func<int, int, int> fun;
            foreach (string c in tokens)
            {
                if (s.Count >= 2 && IsOperation(c, out fun))
                {
                    t2 = s.Pop(); t1 = s.Pop();
                    s.Push(fun(t1, t2));
                }
                else
                    s.Push(int.Parse(c));
            }
            return s.Count >= 1 ? s.Pop() : 0;
    }

        bool IsOperation(string s, out Func<int,int,int> operation)
        {
            operation = null;
            switch(s)
            {
                case "+":
                    operation = (int a,int b) => a + b; return true;
                case "-":
                    operation = (int a, int b) => a - b; return true;
                case "*":
                    operation = (int a, int b) => a * b; return true;
                case "/":
                    operation = (int a, int b) => a / b; return true;
            }
            return false;
        }
}
