/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0) return null;
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        foreach (ListNode node in lists)
            if(node != null)
                pq.Enqueue(node, node.val);

        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        while(pq.Count > 0)
        {
            var node = pq.Dequeue();
            curr.next = node;
            curr = node;
            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);
        }

        return dummy.next;
    }
}
