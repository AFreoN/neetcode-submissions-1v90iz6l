public class Solution {
    public bool CheckValidString(string s) {
            Stack<int> bracketStack = new Stack<int>();
            Stack<int> starStack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') bracketStack.Push(i);
                else if (s[i] == '*') starStack.Push(i);
                else
                {
                    if (bracketStack.Count > 0) bracketStack.Pop();
                    else if(starStack.Count > 0) starStack.Pop();
                    else return false;
                }
            }

            while (bracketStack.Count > 0 && starStack.Count > 0)
            {
                int bIndex = bracketStack.Pop();
                int sIndex = starStack.Pop();
                if (bIndex > sIndex) return false;
            }

            return bracketStack.Count == 0;
    }
}
