KthLargest kthLargest = new KthLargest(2, [0]);
Console.WriteLine(kthLargest.Add(-1));   // returns 4
Console.WriteLine(kthLargest.Add(1));
Console.WriteLine(kthLargest.Add(-2));
Console.WriteLine(kthLargest.Add(-4)); 
Console.WriteLine(kthLargest.Add(3)); 

class KthLargest {
    private PriorityQueue<int, int> minHeap;
    private int k;
    
    public KthLargest(int k, int[] nums)
    {
        minHeap = new PriorityQueue<int, int>();
        this.k = k;
        var index = 0;
        
        for (index = 0; index < k && index < nums.Length; index++)
        {
            minHeap.Enqueue(nums[index], nums[index]);
        }
        
        for (int i = index; i < nums.Length; i++)
        {
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(nums[i], nums[i]);
            }
            if (nums[i] > minHeap.Peek())
            {
                minHeap.Dequeue();
                minHeap.Enqueue(nums[i], nums[i]);
            }
        }
    }
    
    public int Add(int val)
    {
        if (minHeap.Count == 0)
        {
            minHeap.Enqueue(val, val);
            return val;
        }
        
        if (minHeap.Count < k)
        {
            minHeap.Enqueue(val, val);
            return minHeap.Peek();
        }
        
        if (minHeap.Peek() < val)
        {
            minHeap.Dequeue();
            minHeap.Enqueue(val, val);
        }
        
        return minHeap.Peek();
    }
}