public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;
        Stack<char> st = new Stack<char>();
        st.Push(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            if(st.Count > 0 && st.Peek() == GetPair(s[i]))
                st.Pop();
            else st.Push(s[i]);
        }
        return st.Count == 0;
    }
    char GetPair(char a)
    {
        switch(a)
        {
            case ')': return '(';
            case '}': return '{';
            case ']': return '[';
        }
        return ' ';
    }
}
