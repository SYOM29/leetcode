public class SubrectangleQueries {
    private int[][] _rect;

    public SubrectangleQueries(int[][] rectangle) {
        _rect = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for(var r = row1; r <= row2; r++)
        {
            for(var c = col1; c <= col2; c++)
            {
                _rect[r][c] = newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return _rect[row][col];
    }
}
