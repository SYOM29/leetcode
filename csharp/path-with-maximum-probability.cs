// Dijkstra algorithm using Priority Queue
// Time: O(n)
// Space: O(n)
public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end) {
        var visited = new bool[n];
        Array.Fill(visited, false);
        
        var maxProb = double.MinValue;
        var probs = new double[n];
        Array.Fill(probs, double.MinValue);
        probs[start] = 1;
        
        PriorityQueue<(int n,double p)> qu = new PriorityQueue<(int n,double p)>(true);
        // if diff less than 1 then it will be considered equal, hence multiply by 100000 for 5 dig precision
        qu.compare = (x,y)=>Convert.ToInt32((x.p-y.p)*100000); 
        qu.Enqueue((start,1));
        
        while(qu.Count != 0)
        {
            var node = qu.Dequeue().n;
            
            if(node == end) return probs[node];
            
            if(visited[node]) continue;
            
            visited[node] = true;
            
            for(var e = 0; e < edges.Length; e++)
            {
                var a = edges[e][0];
                var b = edges[e][1];

                if(a != node && b != node) continue;
                
                if(a == node)
                {
                    probs[b] = Math.Max(probs[b], succProb[e] * probs[a]);
                    
                    if(probs[b] > maxProb && b == end) maxProb = probs[b];
                    qu.Enqueue((b, probs[b]));
                }
                else
                {
                    probs[a] = Math.Max(probs[a], succProb[e] * probs[b]);
                    
                    if(probs[a] > maxProb && a == end) maxProb = probs[a];
                    qu.Enqueue((a, probs[a]));
                }
            }
        }
        
        return maxProb != double.MinValue ? maxProb : 0;
    }
}

//https://gist.github.com/paralleltree/31045ab26f69b956052c
class PriorityQueue<T>
{
    private List<T> list;
    public int Count { get { return list.Count; } }
    public readonly bool IsDescending;
    public Comparison<T> compare;

    public PriorityQueue()
    {
        list = new List<T>();
    }

    public PriorityQueue(bool isdesc)
        : this()
    {
        IsDescending = isdesc;
    }

    public PriorityQueue(int capacity)
        : this(capacity, false)
    { }

    public PriorityQueue(IEnumerable<T> collection)
        : this(collection, false)
    { }

    public PriorityQueue(int capacity, bool isdesc)
    {
        list = new List<T>(capacity);
        IsDescending = isdesc;
    }

    public PriorityQueue(IEnumerable<T> collection, bool isdesc)
        : this()
    {
        IsDescending = isdesc;
        foreach (var item in collection)
            Enqueue(item);
    }


    public void Enqueue(T x)
    {
        list.Add(x);
        int i = Count - 1;

        while (i > 0)
        {
            int p = (i - 1) / 2;
            if ((IsDescending ? -1 : 1) * compare(list[p], x) <= 0) break;

            list[i] = list[p];
            i = p;
        }

        if (Count > 0) list[i] = x;
    }

    public T Dequeue()
    {
        T target = Peek();
        T root = list[Count - 1];
        list.RemoveAt(Count - 1);

        int i = 0;
        while (i * 2 + 1 < Count)
        {
            int a = i * 2 + 1;
            int b = i * 2 + 2;
            int c = b < Count && (IsDescending ? -1 : 1) * compare(list[b], list[a]) < 0 ? b : a;

            if ((IsDescending ? -1 : 1) * compare(list[c], root) >= 0) break;
            list[i] = list[c];
            i = c;
        }

        if (Count > 0) list[i] = root;
        return target;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Queue is empty.");
        return list[0];
    }

    public void Clear()
    {
        list.Clear();
    }
}