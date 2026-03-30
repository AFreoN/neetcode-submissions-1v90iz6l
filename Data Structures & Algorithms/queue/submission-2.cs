class Deque {
    Node head, tail;

    public Deque()
    {
        head = new Node(-1);
        tail = new Node(1);
        head.next = tail;
        tail.prev = head;
    }

    public bool isEmpty()
    {
        return head.next == tail;
    }

    public void append(int value)
    {
        Node newNode = new Node(value);

        newNode.next = tail;
        newNode.prev = tail.prev;
        tail.prev.next = newNode;
        tail.prev = newNode;
    }

    public void appendleft(int value)
    {
        Node newNode = new Node(value);

        newNode.prev = head;
        newNode.next = head.next;
        head.next.prev = newNode;
        head.next = newNode;
    }

    public int pop()
    {
        if (isEmpty()) return -1;
        return RemoveNode(tail.prev);
    }

    public int popleft()
    {
        if (isEmpty()) return -1;
        return RemoveNode(head.next);
    }

    int RemoveNode(Node node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
        node.prev = null;
        node.next = null;
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
