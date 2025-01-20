var stones = new int[] { 2,2 };

Console.WriteLine(LastStoneWeight(stones));

int LastStoneWeight(int[] stones)
{
    var maxHeap = new PriorityQueue<int, int>();
    foreach (var stone in stones)
    {
        maxHeap.Enqueue(stone, -stone);
    }

    while (maxHeap.Count > 1)
    {
        var y = maxHeap.Dequeue();
        var x = maxHeap.Dequeue();
        var result = y - x;
        if (result != 0)
        {
            maxHeap.Enqueue(result, -result);
        }
    }

    return maxHeap.Count != 0 ? maxHeap.Peek() : 0;
}