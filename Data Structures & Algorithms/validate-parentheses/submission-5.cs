public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                st.Push(c);
            else
            {
                if (st.Count == 0) return false;
                char t = st.Pop();
                if ((c == ')' && t != '(') ||
                    (c == '}' && t != '{') ||
                    (c == ']' && t != '['))
                    return false;
            }
        }
        return st.Count == 0;
    }
}
