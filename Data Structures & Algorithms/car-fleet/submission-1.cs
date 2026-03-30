public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length, fleet = 1;
        (int pos,int speed)[] data = new (int,int)[n];
        for(int i = 0; i < n; i++)
            data[i] = (position[i], speed[i]);

        Array.Sort(data, (a, b) => b.pos.CompareTo(a.pos));

        double prevTime = (double)(target - data[0].pos) / data[0].speed;
        for(int i = 1; i < n; i++)
        {
            double curTime = (double)(target - data[i].pos) / data[i].speed;
            if(curTime > prevTime)
            {
                fleet++;
                prevTime = curTime;
            }
        }
        return fleet;
    }
}
