// Time: O(n)
// Space: O(1)
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null) return false;
        
        var fast = head;
        var slow = head;
        
        while(fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            
            if(fast == slow) return true;
        }
        
        return false;
    }
}