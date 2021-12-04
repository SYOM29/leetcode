// Dijkstra's algorithm
// Time: O(n^2)
// Space: O(n)
public class Solution {
    // k: source node
    // n: number of nodes
    // times[i]: (u, v, w) where u = source, v = target, w = cost
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int selectedVertex = k - 1;

        bool[] visited = new bool[n];
        Array.Fill(visited, false);
        visited[selectedVertex] = true;
        
        int[] vertexCosts = new int[n];
        Array.Fill(vertexCosts, int.MaxValue);
        vertexCosts[selectedVertex] = 0;
        
        for(var i = 0; i < n; i++)
        {
             for(var t = 0; t < times.Length; t++)
             {
                 var u = times[t][0] - 1;

                 if(u != selectedVertex) continue;

                 var v = times[t][1] - 1;
                 var w = times[t][2];

                 if(vertexCosts[v] > vertexCosts[selectedVertex] + w) vertexCosts[v] = vertexCosts[selectedVertex] + w;
             }
             
             var next = -1;
             for(var idx = 0; idx < times.Length; idx++)
             {
                 var u = times[idx][0] - 1;
                 var v = times[idx][1] - 1;
                 
                 if(visited[u] == true 
                    && visited[v] == false 
                    && (next == -1 || vertexCosts[v] < vertexCosts[next])) next = v;
             }
             
             if(next == -1) break;
            
             visited[next] = true;
             selectedVertex = next;
        }
        
        return visited.Any(x => x == false) ? -1 : vertexCosts.Max();
    }
}