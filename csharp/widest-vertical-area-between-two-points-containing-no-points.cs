// Time: O(n log n)
// Space: O(1)
public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        QuickSort(points, 0, points.Length - 1);
        
        var wideArea = int.MinValue;
        
        for(var i = 1; i < points.Length; i++)
        {
            if(points[i][0] - points[i-1][0] > wideArea) wideArea = points[i][0] - points[i-1][0];
        }
        
        return wideArea;
    }
    
    public void QuickSort(int[][] points, int l, int h)
    {
        if(l < h)
        {
            var pivot = Partition(points, l, h);
            QuickSort(points, l, pivot - 1);
            QuickSort(points, pivot + 1, h);
        }
    }
    
    public int Partition(int[][] points, int l, int h)
    {
        var pivot = points[h][0];
        
        var j = l;
        for(var i = l; i < h; i++)
        {
            if(points[i][0] < pivot)
            {
                Swap(points, i, j);
                j++;
            }
        }
        Swap(points, h, j);
        return j;
    }
    
    public void Swap(int[][] points, int i1, int i2)
    {
        var temp = points[i1];
        points[i1] = points[i2];
        points[i2] = temp;
    }
}