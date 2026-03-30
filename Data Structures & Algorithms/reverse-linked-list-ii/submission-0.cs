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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode leftPrev = dummy;

        for(int i = 1; i < left && leftPrev != null; i++)
            leftPrev = leftPrev.next;

        if (leftPrev == null) return dummy.next;

        ListNode rightNext = leftPrev.next;
        for (int i = left; i <= right && rightNext != null; i++)
            rightNext = rightNext.next;

        leftPrev.next = Reverse(leftPrev.next, rightNext);
        return dummy.next;
    }

    /// <summary>
    /// Reverses the node in-between start and end node
    /// </summary>
    /// <param name="left">Node previous to the start of reversal node</param>
    /// <param name="right">Node next to the end of reversal node</param>
    /// <returns>First node after reversal</returns>
    ListNode Reverse(ListNode left, ListNode right)
    {
        ListNode prev = right;
        while(left != right)
        {
            ListNode next = left.next;
            left.next = prev;
            prev = left;
            left = next;
        }
        return prev;
    }
}