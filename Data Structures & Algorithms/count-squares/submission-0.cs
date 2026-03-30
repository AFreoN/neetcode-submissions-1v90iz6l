public class CountSquares {
    Dictionary<(int x, int y), int> points;
    public CountSquares() {
        points = new Dictionary<(int x, int y), int>();
    }
    
    public void Add(int[] point) {
        var v = (point[0], point[1]);
        points[v] = points.GetValueOrDefault(v) + 1;
    }
    
    public int Count(int[] point) {
        int x = point[0], y = point[1];
        int res = 0;

        foreach(var v in points)
        {
            int px = v.Key.x, py = v.Key.y;
            if (Math.Abs(px - x) != Math.Abs(py - y) || x == px || y == py) continue;

            res += (v.Value * points.GetValueOrDefault((x, py)) * points.GetValueOrDefault((px, y)));
        }
        return res;
    }
}
