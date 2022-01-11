public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        if(numRows == 0) return triangle;
        
        triangle.Add(new List<int>() { 1 });
        if(numRows == 1) return triangle;

        triangle.Add(new List<int>() { 1, 1 });
        
        for(int i = 3; i <= numRows; i++)
        {
            var newRow = new List<int>() { 1 };
            
            var prevRow = triangle[triangle.Count - 1];
            for(int j = 0; j < i - 2; j++)
            {
                newRow.Add(prevRow[j] + prevRow[j + 1]);
            }
            
            newRow.Add(1);
            triangle.Add(newRow);
        }
        
        return triangle;
    }
}