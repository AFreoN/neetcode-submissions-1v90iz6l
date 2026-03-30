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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0), l = dummy, r = dummy;
        dummy.next = head;
        for(int i = 0; i <= n; i ++)
            r = r.next;

        while(r != null)
        {
            l = l.next;
            r = r.next;
        }
        l.next = l.next.next;
        return dummy.next;
    }
}
