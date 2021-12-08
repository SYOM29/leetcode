// Dijkstra algorithm
// Time: O(n^3)
// Space: O(n)
public class Solution {
    public int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var numOfCities = new int[n];
        Array.Fill(numOfCities, 0);

        for (var i = 0; i < n; i++)
        {
            numOfCities[i] = Dijkstra(i, n, edges, distanceThreshold);
        }

        var currMinIndex = 0;
        var currMin = int.MaxValue;

        for (var i = numOfCities.Length - 1; i >= 0; i--)
        {
            if (numOfCities[i] < currMin)
            {
                currMinIndex = i;
                currMin = numOfCities[i];
            }
        }

        return currMinIndex;
    }

    public int Dijkstra(int start, int n, int[][] edges, int distanceThreshold)
    {
        var visited = new bool[n];
        Array.Fill(visited, false);

        var costs = new int[n];
        Array.Fill(costs, int.MaxValue);
        costs[start] = 0;

        for (var t = 0; t < n; t++)
        {
            var node = GetMinVertex(costs, visited);

            // none of the nodes are reachable
            if (node == -1) break;

            visited[node] = true;

            for (var e = 0; e < edges.Length; e++)
            {
                // since from is a keyword in c# use fromI
                var fromI = edges[e][0];
                var to = edges[e][1];

                // since edges are bidirectional check for both from and to
                if (fromI != node && to != node) continue;

                var w = edges[e][2];

                if (fromI == node)
                {
                    costs[to] = Math.Min(costs[to], costs[node] + w);
                }
                else
                {
                    costs[fromI] = Math.Min(costs[fromI], costs[node] + w);
                }
            }
        }

        return GetNumOfReachableCitiesUndeThreshold(start, costs, distanceThreshold);
    }

    public int GetNumOfReachableCitiesUndeThreshold(int start, int[] costs, int thresh)
    {
        var num = 0;

        for (var i = 0; i < costs.Length; i++)
        {
            if (i == start) continue;
            if (costs[i] <= thresh) num++;
        }

        return num;
    }

    public int GetMinVertex(int[] costs, bool[] visited)
    {
        var min = int.MaxValue;
        var idx = -1;

        for (var i = 0; i < costs.Length; i++)
        {
            if (!visited[i] && costs[i] < min && costs[i] != int.MaxValue)
            {
                idx = i;
                min = costs[i];
            }
        }

        return idx;
    }
}