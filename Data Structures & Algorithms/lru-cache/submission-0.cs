public class LRUCache {
    int capacity;
    Dictionary<int, Node> map;
    Node lru, mru;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        map = new Dictionary<int, Node>();
        lru = new Node(0, 0);
        mru = new Node(0,0);
        lru.Next = mru;
        mru.Prev = lru;
    }
    
    public int Get(int key) {
        if(map.TryGetValue(key, out Node n))
        {
            Remove(n);
            Insert(n);
            return n.Val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(map.TryGetValue(key, out Node n))
        {
            n.Val = value;
            Remove(n);
            Insert(n);
            return;
        }
        Node node = new Node(key, value);
        map[key] = node;
        Insert(node);

        if(map.Count > capacity)   //tail removal logic need
        {
            Node lastNode = lru.Next;
            Remove(lastNode);
            map.Remove(lastNode.Key);
        }
    }

    void Insert(Node node)
    {
        Node prev = mru.Prev;
        Node next = mru;
        prev.Next = node;
        mru.Prev = node;
        node.Prev = prev;
        node.Next = mru;
    }

    void Remove(Node last)
    {
        Node prev = last.Prev;
        Node next = last.Next;
        prev.Next = next;
        next.Prev = prev;
        last.Prev = null;
        last.Next = null;
    }
}

public class Node {
    public int Key { get; set; }
    public int Val { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }

    public Node(int key, int val) {
        Key = key;
        Val = val;
        Prev = null;
        Next = null;
    }
}
