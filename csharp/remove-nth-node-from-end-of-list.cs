// Time: O(n)
// Space: O(n)
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null) return null;
        
        var stack = new Stack<ListNode>();
        var curr = head;
        
        while(curr != null)
        {
            stack.Push(curr);
            curr = curr.next;
        }
        
        ListNode node = null;
        for(var i = 1; i <= n + 1; i++)
        {
            if(stack.Count() == 0) return node.next;
            node = stack.Pop();
        }
        
        node.next = node.next.next;
        
        return head;
    }
}