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
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        ListNode fast = head;
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            head = head.next;
            if (fast == head) return true;
        }
        return false;
    }
}
