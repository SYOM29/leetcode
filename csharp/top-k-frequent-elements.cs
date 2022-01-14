// Using custom priority queue
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new PriorityQueue();
        
        for(var i = 0; i < nums.Length; i++)
        {
            counts.AddOrIncrement(nums[i]);
        }
        
        var result = new int[k];
        
        for(var i = 0; i < k; i++)
        {
            result[i] = counts.PopKey();
        }
        
        return result;
    }
}


class PriorityQueue
{
    PriorityQueueNode queue;

    public PriorityQueue()
    {
        queue = new PriorityQueueNode(-1, 1);
    }

    public void AddOrIncrement(int key)
    {
        var newNode = new PriorityQueueNode(key, 1);

        if (queue.next == null)
        {
            queue.next = newNode;
            return;
        }

        // if key already exists increment
        var curr = queue.next;
        var prev = queue;
        while (curr != null)
        {
            if (curr.key == key)
            {
                curr.val += 1;
                if(prev.val < curr.val) Rebalance(prev, curr);
                return;
            }
            curr = curr.next;
            prev = prev.next;
        }

        prev.next = newNode;
    }

    private void Rebalance(PriorityQueueNode prevNode, PriorityQueueNode node)
    {
        var prev = queue;
        var curr = queue.next;
        while (curr.val > node.val && curr != node)
        {
            curr = curr.next;
            prev = prev.next;
        }

        if (curr != node)
        {
            prev.next = node;
            prevNode.next = prevNode.next.next;
            node.next = curr;
        }
    }

    public int PopKey()
    {
        if (queue.next == null) throw new Exception("Queue is empty!");
        var key = queue.next.key;
        queue.next = queue.next.next;
        return key;
    }
}

class PriorityQueueNode
{
    public int val;
    public int key;
    public PriorityQueueNode next;

    public PriorityQueueNode(int key, int val)
    {
        this.key = key;
        this.val = val;
        next = null;
    }
}