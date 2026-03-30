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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        int r = 0;
        while(l1 != null || l2 != null || r != 0)
        {
            int v1 = 0, v2 = 0;
            if(l1 != null)
            {
                v1 = l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                v2 = l2.val;
                l2 = l2.next;
            }
            int fin = v1 + v2 + r;
            if (fin > 9) r = 1;
            else r = 0;
            current.next = new ListNode(fin % 10);
            current = current.next;
        }

        return dummy.next;
    }
}
