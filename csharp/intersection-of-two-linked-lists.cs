// Time: O(n+m)
// Space: O(1)
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null) return null;
        
        ListNode pointerA = headA;
        ListNode pointerB = headB;
        
        while(pointerA != pointerB)
        {
            pointerA = pointerA == null ? headB : pointerA.next;
            pointerB = pointerB == null ? headA : pointerB.next;
        }
        
        return pointerA;
    }
}