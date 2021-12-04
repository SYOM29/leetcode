// Time: O(n)
// Space: O(1)
public class Solution {
    public void DeleteNode(ListNode node) {
        while(node != null)
        {
            node.val = node.next.val;
            
            if(node.next.next == null)
            {
                node.next = null;
            }
            
            node = node.next;
        }
    }
}