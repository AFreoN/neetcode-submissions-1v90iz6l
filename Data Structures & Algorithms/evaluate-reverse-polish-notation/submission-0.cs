public class Solution {
    public int EvalRPN(string[] tokens) {
            int r = 0;
            Stack<int> s = new Stack<int>();
            foreach(string c in tokens)
            {
                //If number, store in stack
                if(int.TryParse(c, out int i))
                    s.Push(i);
                else if(s.Count >= 2)
                {
                    int t1 = s.Pop(), t2 = s.Pop();
                    switch(c)
                    {
                        case "+": 
                            r = t1 + t2;
                            break;
                        case "-":
                            r = t2 - t1;
                            break;
                        case "*":
                            r = t2 * t1;
                            break;
                        case "/":
                            r = t2 / t1;
                            break;
                    }
                    s.Push(r);
                }
            }
            return s.Count >= 1 ? s.Pop() : 0;
    }
}
