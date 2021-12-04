// Time: O(n)
// Space: O(n)
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        ListNode head = null;
        
        if(list1 != null && list1.val <= list2.val)
        {
            head = new ListNode(list1.val);
            list1 = list1.next;
        }
        else
        {
            head = new ListNode(list2.val);
            list2 = list2.next;
        }
        
        var curr = head;
        
        while(list1 != null || list2 != null)
        {
            if(list1 == null)
            {
                curr.next = new ListNode(list2.val);
                curr = curr.next;
                list2 = list2.next;
            }
            else if(list2 == null)
            {
                curr.next = new ListNode(list1.val);
                curr = curr.next;
                list1 = list1.next;
            }
            else if(list1.val < list2.val)
            {
                curr.next = new ListNode(list1.val);
                curr = curr.next;
                list1 = list1.next;
            }
            else
            {
                curr.next = new ListNode(list2.val);
                curr = curr.next;
                list2 = list2.next;
            }
        }
        
        return head;
    }
}