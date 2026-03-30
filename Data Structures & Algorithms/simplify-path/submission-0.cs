public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string[] parts = path.Split('/');
        int skipCount = 0;

        for (int i = parts.Length - 1; i >= 0; i--)
        {
            if (string.IsNullOrEmpty(parts[i]) || parts[i] == ".") continue;
            if (parts[i] == "..")
            {
                skipCount++;
                continue;
            }
            if(skipCount > 0)
            {
                skipCount--;
                continue;
            }
            stack.Push(parts[i]);
        }
        return "/" + string.Join("/", stack);
    }
}