public class MyHashSet {
    int[] bit;
    public MyHashSet()
    {
        bit = new int[31251];
    }

    public void Add(int key)
    {
        bit[key / 32] |= GetMask(key);
    }

    public void Remove(int key)
    {
        bit[key / 32] &= ~GetMask(key);
    }

    public bool Contains(int key)
    {
        return (bit[key / 32] & GetMask(key)) != 0;
    }

    int GetMask(int key)
    {
        return 1 << (key % 32);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */