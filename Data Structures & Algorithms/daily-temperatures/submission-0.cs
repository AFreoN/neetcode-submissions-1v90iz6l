public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>();
        
        for(int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];
            while(stack.Count > 0 && t > stack.Peek()[0])
            {
                int pi = stack.Pop()[1];
                result[pi] = i - pi;
            }
            stack.Push([t, i]);
        }
        return result;        
    }
}
