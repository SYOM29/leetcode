// Recursive solution would be way better
// Time: O(n)
// Space: O(n)
public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;

        var newGraph = new Node(node.val);
        var stack = new Stack<Node>();
        var oldStack = new Stack<Node>();
        var visited = new HashSet<Node>();
        var prev = node;
        var curr = newGraph;
        visited.Add(newGraph);

        while (prev != null && curr != null && curr.val == prev.val)
        {
            foreach (var n in prev.neighbors)
            {
                if (!curr.neighbors.Any(x => x.val == n.val))
                {
                    var vis = visited.FirstOrDefault(x => x.val == n.val);
                    var newNode = vis == null ? new Node(n.val) : vis;
                    curr.neighbors.Add(newNode);

                    if (vis == null)
                    {
                        stack.Push(n);
                        oldStack.Push(newNode);
                        visited.Add(newNode);
                    }
                }
            }

            prev = stack.Count != 0 ? stack.Pop() : null;
            curr = oldStack.Count != 0 ? oldStack.Pop() : null;
        }

        return newGraph;
    }
}