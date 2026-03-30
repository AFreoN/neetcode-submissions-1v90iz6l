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
        ListNode fast = head;
        while(head != null && fast != null && fast.next != null)
        {
            fast = fast.next.next;
            head = head.next;
            if (fast == head) return true;
        }
        return false;
    }
}
