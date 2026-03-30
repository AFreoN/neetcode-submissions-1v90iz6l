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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode currentHead = dummy;

        while (true)
        {
            // calculate kth node
            ListNode kth = currentHead;
            for(int i = 0; i < k && kth != null; i++)
                kth = kth.next;

            if (kth == null) break;

            // reverse nodes

            Reverse(currentHead.next, kth.next);    //kth next is 4

            //Reconnect
            ListNode oldHead = currentHead.next; //1
            currentHead.next = kth; //dummy -> 3
            currentHead = oldHead;    // to 1 (now sits at tail)
        }

        return dummy.next;
    }

    void Reverse(ListNode head, ListNode target)
    {
        ListNode prev = target;
        while(head != target)
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
    }
}
