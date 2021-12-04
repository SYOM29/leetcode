// Iterative
// Time: O(n)
// Space: O(n)
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;
        
        ListNode temp = new ListNode(head.val);
        head = head.next;
        
        while(head != null)
        {
            var newNode = new ListNode(head.val);
            newNode.next = temp;
            temp = newNode;
            head = head.next;
        }
        
        return temp;
    }
}

// Recursive
// Time: O(n)
// Space: O(n)
public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var newHead = new ListNode(head.val);
        head = head.next;

        return ReverseRecursively(head, newHead);
    }

    public ListNode ReverseRecursively(ListNode oldHead, ListNode temp)
    {
        if (oldHead == null) return temp;

        var newNode = new ListNode(oldHead.val);
        newNode.next = temp;
        temp = newNode;
        oldHead = oldHead.next;

        return ReverseRecursively(oldHead, temp);
    }
}