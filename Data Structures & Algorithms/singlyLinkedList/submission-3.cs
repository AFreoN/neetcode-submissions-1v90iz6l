public class LinkedList {
    ListNode head, tail;

    public LinkedList()
    {
        head = new ListNode(-1);
        tail = head;
    }

    public int Get(int index)
    {
        ListNode curr = head.next;
        int i = 0;

        while(curr != null)
        {
            if (i++ == index) return curr.val;
            curr = curr.next;
        }

        return -1;  // either out of bounds or list is empty
    }

    public void InsertHead(int val)
    {
        ListNode newHead = new ListNode(val);
        newHead.next = head.next;
        head.next = newHead;
        if (newHead.next == null)
            tail = newHead;
    }

    public void InsertTail(int val)
    {
        tail.next = new ListNode(val);
        tail = tail.next;
    }

    public bool Remove(int index)
    {
        int i = 0;
        ListNode curr = head;

        while (curr != null && i < index)
        {
            curr = curr.next;
            i++;
        }

        // Remove the node ahead of curr
        if (curr != null && curr.next != null)
        {
            if (curr.next == tail)
                tail = curr;
            curr.next = curr.next.next;
            return true;
        }
        return false;
    }

    public List<int> GetValues()
    {
        List<int> result = new List<int>();
        ListNode curr = head.next;

        while (curr != null)
        {
            result.Add(curr.val);
            curr = curr.next;
        }
        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int _val)
    {
        val = _val;
    }

    public ListNode(int _val, ListNode _next)
    {
        val = _val;
        next = _next;
    }
}