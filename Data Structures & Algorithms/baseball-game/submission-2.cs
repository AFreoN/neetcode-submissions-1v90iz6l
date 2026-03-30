public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> points = new Stack<int>();
        foreach(string s in operations)
        {
            switch(s[0])
            {
                case '+':
                    int second = points.Pop();
                    int sum = second + points.Peek();
                    points.Push(second);
                    points.Push(sum);
                    break;
                case 'C':
                    points.Pop();
                    break;
                case 'D':
                    points.Push(points.Peek() * 2);
                    break;
                default:
                    points.Push(int.Parse(s));
                    break;
            }
        }

        int res = 0;
        foreach (int point in points)
            res += point;
        return res;
    }
}