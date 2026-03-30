public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        Stack<int> stack = new Stack<int>();    //we're going to store index with most value
        int maxArea = heights[0];
        stack.Push(0);

        for(int i = 0; i <= n; i++)
        {
            //if prev height is greater/equals current, that means prev no longer extends. Do max compute immediately
            while(stack.Count > 0 && (i == n || heights[stack.Peek()] >= heights[i]))
            {
                int height = heights[stack.Pop()];  //get prev height
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
            stack.Push(i);
        }

        return maxArea;
    }
}
