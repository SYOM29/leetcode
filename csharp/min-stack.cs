public class MinStack {
    private List<int> _stack;
    private int _minIndex;
    
    public MinStack() {
        _stack = new List<int>();
        _minIndex = 0;
    }
    
    public void Push(int val) {
        _stack.Add(val);
        
        if(val < _stack[_minIndex]) _minIndex = _stack.Count - 1;
    }
    
    public void Pop() {
        _stack.RemoveAt(_stack.Count - 1);

        if (_stack.Count == _minIndex)
        {
            var newMinIndex = 0;

            foreach (var i in _stack)
            {
                if (newMinIndex == -1 || i < _stack[newMinIndex]) newMinIndex = _stack.IndexOf(i);
            }

            _minIndex = newMinIndex != -1 ? newMinIndex : 0;
        }
    }
    
    public int Top() {
        return _stack.ElementAtOrDefault(_stack.Count - 1);
    }
    
    public int GetMin() {
        return _stack[_minIndex];
    }
}