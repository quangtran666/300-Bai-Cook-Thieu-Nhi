var arr = new int[] { 1, 2, 3, 4, 5 };

var k = 4;

var x = 3;

Console.WriteLine(string.Join(", ", FindClosestElements(arr, k, x)));

IList<int> FindClosestElements(int[] arr, int k, int x)
{
    var maxHeap = new PriorityQueue<Tuple<int, int>, int>();

    foreach (var i in arr)
    {
        var distance = Math.Abs(i - x);

        if (maxHeap.Count < k)
        {
            maxHeap.Enqueue(new Tuple<int, int>(distance, i), -distance);
        } else if (distance < maxHeap.Peek().Item1)
        {
            maxHeap.Dequeue();
            maxHeap.Enqueue(new Tuple<int, int>(distance, i), -distance);
        }
    }
    
    var result = new List<int>();
    while (maxHeap.Count > 0)
    {
        result.Add(maxHeap.Dequeue().Item2);
    }
    
    result.Sort();
    
    return result;
}