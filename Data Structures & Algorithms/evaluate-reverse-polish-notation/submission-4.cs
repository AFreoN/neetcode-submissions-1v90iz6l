public class Solution {
    public int EvalRPN(string[] tokens) {
            int l,r;
            Stack<int> s = new Stack<int>();
            foreach (string c in tokens)
            {
                //If number, store in stack
                if (int.TryParse(c, out int i))
                    s.Push(i);
                else
                {
                    r = s.Pop(); l = s.Pop();
                    int o = c switch
                    {
                        "+" => l + r,
                        "-" => l - r,
                        "*" => l * r,
                        "/" => l / r,
                        _ => throw new InvalidOperationException()
                    };
                    s.Push(o);
                }
            }
            return s.Count >= 1 ? s.Pop() : 0;
    }
}
