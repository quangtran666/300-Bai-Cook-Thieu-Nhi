var nums = new int[] { 3,2,3,1,2,4,5,5,6 };

var k = 4;

Console.WriteLine(FindKthLargest(nums, k));

int FindKthLargest(int[] nums, int k)
{
    var minHeap = new PriorityQueue<int, int>();
    for (int i = 0; i < k; i++)
    {
        minHeap.Enqueue(nums[i], nums[i]);
    }

    for (var i = k; i < nums.Length; i++)
    {
        if (nums[i] > minHeap.Peek())
        {
            minHeap.Dequeue();
            minHeap.Enqueue(nums[i], nums[i]);
        }
    }
    
    return minHeap.Peek();
}