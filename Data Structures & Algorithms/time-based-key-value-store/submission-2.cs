public class TimeMap {
    Dictionary<string, List<(int, string)>> map;
    
    public TimeMap()
    {
        map = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if(map.TryGetValue(key, out List<(int, string)> list))
            list.Add((timestamp, value));
        else
            map.Add(key, new List<(int, string)> { (timestamp, value) });
    }

    public string Get(string key, int timestamp)
    {
        if (map.TryGetValue(key, out var list))
        {
            //Do binary search
            string res = string.Empty;
            int l = 0, r = list.Count - 1;
            while(l <= r)
            {
                int m = l + (r - l) / 2;

                if (list[m].Item1 <= timestamp)
                {
                    l = m + 1;
                    res = list[m].Item2;
                }
                else r = m - 1;
            }
            return res;
        }
        else return string.Empty;
    }
}
