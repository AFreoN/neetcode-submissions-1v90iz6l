class Deque {
    Node head, tail;
    int count;

    public Deque()
    {
        head = new Node(-1);
        tail = new Node(1);
        head.next = tail;
        tail.prev = head;
        count = 0;
    }

    public bool isEmpty()
    {
        return count == 0;
    }

    public void append(int value)
    {
        Node newNode = new Node(value);

        newNode.next = tail;
        newNode.prev = tail.prev;
        tail.prev.next = newNode;
        tail.prev = newNode;

        count++;
    }

    public void appendleft(int value)
    {
        Node newNode = new Node(value);

        newNode.prev = head;
        newNode.next = head.next;
        head.next.prev = newNode;
        head.next = newNode;

        count++;
    }

    public int pop()
    {
        if (count == 0) return -1;
        return RemoveNode(tail.prev);
    }

    public int popleft()
    {
        if(count == 0) return -1;
        return RemoveNode(head.next);
    }

    int RemoveNode(Node node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
        node.prev = null;
        node.next = null;
        count--;
        return node.val;
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node prev;

    public Node(int val)
    {
        this.val = val;
    }

    public Node(int val, Node prev, Node next)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}
