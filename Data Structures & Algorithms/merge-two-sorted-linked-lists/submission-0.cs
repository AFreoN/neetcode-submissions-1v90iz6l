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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while(list1 != null && list2 != null)
        {
            if (list2.val <= list1.val)
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            else
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            current = current.next;
        }
        while(list1 != null)
        {
            current.next = new ListNode(list1.val);
            list1 = list1.next;
            current = current.next;
        }

        while (list2 != null)
        {
            current.next = new ListNode(list2.val);
            list2 = list2.next;
            current = current.next;
        }

        return dummy.next;
    }
}