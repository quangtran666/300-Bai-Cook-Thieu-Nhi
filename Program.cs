var minStack = new MinStack();
minStack.Push(0);
minStack.Push(1);
minStack.Push(0);
minStack.GetMin(); 
minStack.Pop();    
minStack.GetMin();
Console.WriteLine("");

public class MinStack
{
    private List<int> stack;
    private int MinValueIndex = 0;
    private Dictionary<int, int> indexes = new();
    
    public MinStack()
    {
        stack = [];
    }
    
    public void Push(int val) {
        stack.Add(val);
    
        if (stack[MinValueIndex] >= stack[^1])
        {
            indexes[stack.Count - 1] = MinValueIndex;
            MinValueIndex = stack.Count - 1;
        } 
    }
    
    public void Pop()
    {
        if (stack.Count == 0) return;
        
        if (stack[^1] <= stack[MinValueIndex])
            MinValueIndex = indexes[stack.Count - 1];

        stack.RemoveAt(stack.Count - 1);
    }
    
    public int Top() {
        return stack[^1];
    }
    
    public int GetMin() {
        return stack[MinValueIndex];
    }
}