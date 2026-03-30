public class MyHashSet {
    List<int> hash;
    public MyHashSet()
    {
        hash = new List<int>();
    }

    public void Add(int key)
    {
        if(!hash.Contains(key)) 
            hash.Add(key);
    }

    public void Remove(int key)
    {
        if(hash.Contains(key))
            hash.Remove(key);
    }

    public bool Contains(int key)
    {
        return hash.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */