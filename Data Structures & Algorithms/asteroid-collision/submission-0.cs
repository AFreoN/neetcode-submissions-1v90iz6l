public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        foreach (int ast in asteroids)
        {
            if(ast > 0 || stack.Count == 0 || stack.Peek() < 0)
            {
                stack.Push(ast);
                continue;
            }

            int v = Math.Abs(ast);
            bool add = true;
            while(stack.Count > 0 && stack.Peek() > 0)
            {
                if(v <= stack.Peek())
                {
                    if(v == stack.Peek()) stack.Pop();
                    add = false;
                    break;
                }
                else if(v > stack.Peek())
                {
                    stack.Pop();
                }
            }
            if (add) stack.Push(ast);
        }
        int[] result = new int[stack.Count];
        for(int i = stack.Count - 1; i >= 0; i--)
            result[i] = stack.Pop();
        return result;
    }
}