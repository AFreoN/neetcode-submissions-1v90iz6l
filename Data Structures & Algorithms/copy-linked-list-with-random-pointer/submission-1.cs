/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> map = new Dictionary<Node, Node>();
    public Node copyRandomList(Node head) {
        if(head == null) return null;
        if (map.ContainsKey(head)) return map[head];

        Node copy = new Node(head.val);
        map[head] = copy;
        copy.next = copyRandomList(head.next);
        copy.random = head.random != null ? copyRandomList(head.random) : null;

        return copy;
    }
}
