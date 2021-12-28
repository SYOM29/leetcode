public class Solution {
    public bool ValidPath(int n, int[][] edges, int start, int end) {
        if(n == 1) return true;
        
        var visited = new bool[n];
        Array.Fill(visited, false);
        
        var queue = new Queue<int>();
        queue.Enqueue(start);
        
        int curr = -1;
        while(queue.Count() != 0)
        {
            curr = queue.Dequeue();
            visited[curr] = true;
            
            for(var i = 0; i < edges.Length; i++)
            {
                var u = edges[i][0];
                var v = edges[i][1];
                
                if(u != curr && v != curr) continue;
                
                if(u == curr)
                {
                    if(v == end) return true;
                    if(!visited[v]) queue.Enqueue(v);
                }
                else
                {
                    if(u == end) return true;
                    if(!visited[u]) queue.Enqueue(u);
                }
            }
        }
        
        return false;
    }
}