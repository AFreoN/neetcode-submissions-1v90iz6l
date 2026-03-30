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
        ListNode right = head;
        int i = 1;
        while (right != null && i < n)
        {
            right = right.next;
            i++;
        }
        
        if (right.next == null) return head.next;

        ListNode left = head, tmp = null;
        while(right.next != null)
        {
            tmp = left;
            left = left.next;
            right = right.next;
        }
        tmp.next = left.next;
        return head;
    }
}
