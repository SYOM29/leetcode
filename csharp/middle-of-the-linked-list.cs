// Sliding window technique
// Time: O(n)
// Space: O(1)
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if(head == null || head.next == null) return head;
        
        var fast = head;
        var slow = head;
        
        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return fast.next != null ? slow.next : slow;
    }
}